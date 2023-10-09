using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using PatientFeedback.DTOs.Enums;
using PatientFeedback.DTOs.Request;
using PatientFeedback.DTOs.Response;
using PatientFeedback.DTOs.ViewModels;
using PatientFeedback.Entities;

namespace PatientFeedback.Services;

public interface IAppointmentService
{
    Task<ApiResponse<GetAppointmentResponse>> GetAppointmentById(string appointmentId);

    Task<ApiResponse<GetAppointmentFeedbackResponse>> GetAppointmentFeedback(string appointmentId);

    Task<ApiResponse<SaveAppointmentFeedbackResponse>> SaveAppointmentFeedback(SaveFeedbackRequest request);
}

public class AppointmentService : IAppointmentService
{
    private readonly PatientFeedbackContext _context;
    private Regex _rx = new (@"{.*?}",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);
    // (?<=\{)[^}]*(?=\})
    // {.*?}
    
    public AppointmentService(PatientFeedbackContext context)
    {
        _context = context;
    }
    
    public async Task<ApiResponse<GetAppointmentResponse>> GetAppointmentById(string appointmentId)
    {
        var appointment = await _context.Appointments!
            .Include(appt => appt.Patient)
                .ThenInclude(p => p.Addresses)
            .Include(appt => appt.Patient)
                .ThenInclude(c => c.Contacts)
            .Include(appt => appt.Doctor)
            .Include(appt => appt.Diagnoses)
            .ThenInclude(d => d.Codings)
            .FirstOrDefaultAsync(appt => appt.Id.ToString() == appointmentId);

        var response = new ApiResponse<GetAppointmentResponse>();
        if (appointment is null)
        {
            response.ErrorMessage = $"Unable to load the specified Appointment [{appointmentId}].";
            response.ErrorCode = ErrorCode.NotFound;
            return response;
        }

        response.Data = new GetAppointmentResponse(appointment.ToAppointmentResponse(),
            appointment.Patient.ToPatientResponse(),
            appointment.Doctor.ToDoctorResponse(),
            appointment.Diagnoses.Select(d => d.ToDiagnosisResponse()).ToList());
        return response;
    }

    public async Task<ApiResponse<GetAppointmentFeedbackResponse>> GetAppointmentFeedback(string appointmentId)
    {
        var response = new ApiResponse<GetAppointmentFeedbackResponse>();
        
        var appointment = await _context.Appointments!
            .Include(appt => appt.Patient)
            .Include(appt => appt.Doctor)
            .Include(appt => appt.Diagnoses)
                .ThenInclude(d => d.Codings)            
            .Include(appt => appt.AppointmentFeedback)
                .ThenInclude(af => af.AppointmentFeedbackQuestions)
                    .ThenInclude(afq => afq.FeedbackQuestion)
            .Include(appt => appt.AppointmentFeedback)
                .ThenInclude(af => af.AppointmentFeedbackQuestions)
                    .ThenInclude(afq => afq.FeedbackAnswer)
            .FirstOrDefaultAsync(appt => appt.Id.ToString() == appointmentId);
        
        if (appointment is null)
        {
            response.ErrorCode = ErrorCode.NotFound;
            response.ErrorMessage = $"Unable to load the specified Appointment [{appointmentId}].";
            return response;
        }
        
        var lookupKeys = new Dictionary<string, string>
        {
            {"{patient_first_name}", appointment.Patient.GivenName},
            {"{doctor_last_name}", appointment.Doctor.FamilyName},
            {"{diagnosis}", appointment.Diagnoses.First().Codings.First().Name} // TODO: 
        };

        var feedbackQuestions = appointment.AppointmentFeedback.AppointmentFeedbackQuestions
            .OrderBy(afq => afq.Order)
            .ToList();
        var questionViewModels = HydrateQuestionText(lookupKeys, feedbackQuestions);
        
        response.Data = new GetAppointmentFeedbackResponse(appointment.Id.ToString(), 
            appointment.AppointmentType, 
            appointment.Status, 
            appointment.AppointmentFeedback.Id.ToString(),
            appointment.AppointmentFeedback.SubmittedDate,
            questionViewModels);
        return response;
    }

    public async Task<ApiResponse<SaveAppointmentFeedbackResponse>> SaveAppointmentFeedback(SaveFeedbackRequest request)
    {
        var response = new ApiResponse<SaveAppointmentFeedbackResponse>();

        if (request.QuestionAnswers is null || !request.QuestionAnswers.Any())
        {
            response.ErrorCode = ErrorCode.BadRequest;
            return response;
        }
        
        var appointment = await _context.Appointments!
            .Include(appt => appt.Patient)
            .Include(appt => appt.Doctor)
            .Include(appt => appt.Diagnoses)
                .ThenInclude(d => d.Codings)           
            .Include(appt => appt.AppointmentFeedback)
                .ThenInclude(af => af.AppointmentFeedbackQuestions)
                    .ThenInclude(afq => afq.FeedbackQuestion)
            .FirstOrDefaultAsync(appt => appt.Id.ToString() == request.AppointmentId);
        
        if (appointment is null)
        {
            response.ErrorCode = ErrorCode.NotFound;
            response.ErrorMessage = $"Unable to load the specified Appointment [{request.AppointmentId}].";
            return response;
        }

        if (appointment.AppointmentFeedback.SubmittedDate.HasValue)
        {
            response.ErrorCode = ErrorCode.BadRequest;
            response.ErrorMessage = $"Appointment feedback already recorded";
            return response;
        }
        
        appointment.AppointmentFeedback.SubmittedDate = DateTime.UtcNow;

        var answers = request.QuestionAnswers.ToDictionary(qa => qa.AppointmentFeedbackQuestionId!, qa => qa.Value);
        foreach (var afq in appointment.AppointmentFeedback.AppointmentFeedbackQuestions)
        {
            var questionId = afq.FeedbackQuestionId.ToString();
            afq.FeedbackAnswer = new FeedbackAnswer
            {
                Value = answers[questionId] ?? string.Empty
            };
        }

        await _context.SaveChangesAsync();
        
        var lookupKeys = new Dictionary<string, string>
        {
            {"{patient_first_name}", appointment.Patient.GivenName},
            {"{doctor_last_name}", appointment.Doctor.FamilyName},
            {"{diagnosis}", appointment.Diagnoses.First().Codings.First().Name} // TODO: 
        };
        var feedbackQuestions = appointment.AppointmentFeedback.AppointmentFeedbackQuestions
            .OrderBy(afq => afq.Order)
            .ToList();
        var questionViewModels = HydrateQuestionText(lookupKeys, feedbackQuestions);
        
        // questionId => question answer
        var questionAnswers = questionViewModels
            .Select(afq => new QuestionAnswerResponse(afq.Text, answers[afq.QuestionId] ))
            .ToList();
        
        response.Data = new SaveAppointmentFeedbackResponse(questionAnswers);
        return response;
    }

    private List<AppointmentFeedbackQuestionResponse> HydrateQuestionText(Dictionary<string, string> lookupKeys, List<AppointmentFeedbackQuestion> questions)
    {
        var questionViewModels = new List<AppointmentFeedbackQuestionResponse>();
        foreach (var question in questions)
        {
            var questionText = question.FeedbackQuestion.Text;
            foreach (Match match in _rx.Matches(questionText))
            {
                questionText = questionText.Replace(match.Value, lookupKeys[match.Value]);
            }

            question.FeedbackQuestion.Text = questionText;
            questionViewModels.Add(question.ToAppointmentFeedbackQuestionResponse());
        }

        return questionViewModels;
    }
}