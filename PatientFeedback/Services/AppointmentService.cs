using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using PatientFeedback.DTOs.Enums;
using PatientFeedback.DTOs.Response;
using PatientFeedback.DTOs.ViewModels;

namespace PatientFeedback.Services;

public interface IAppointmentService
{
    Task<ApiResponse<GetAppointmentResponse>> GetAppointmentById(string appointmentId);

    Task<ApiResponse<GetAppointmentFeedbackResponse>> GetAppointmentFeedback(string appointmentId);
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
                .ThenInclude(d => d.Codings)            .Include(appt => appt.AppointmentFeedback)
                .ThenInclude(af => af.AppointmentFeedbackQuestions)
                .ThenInclude(afq => afq.FeedbackQuestion)
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
        
        var questionViewModels = new List<AppointmentFeedbackQuestionResponse>();
        foreach (var question in appointment.AppointmentFeedback.AppointmentFeedbackQuestions.OrderBy(afq => afq.Order))
        {
            var questionText = question.FeedbackQuestion.Text;
            foreach (Match match in _rx.Matches(questionText))
            {
                questionText = questionText.Replace(match.Value, lookupKeys[match.Value]);
            }

            question.FeedbackQuestion.Text = questionText;
            questionViewModels.Add(question.ToAppointmentFeedbackQuestionResponse());
        }
        
        response.Data = new GetAppointmentFeedbackResponse(appointment.Id.ToString(), 
            appointment.AppointmentType, 
            appointment.Status, 
            appointment.AppointmentFeedback.Id.ToString(),
            appointment.AppointmentFeedback.SubmittedDate,
            questionViewModels);
        return response;
    }
}