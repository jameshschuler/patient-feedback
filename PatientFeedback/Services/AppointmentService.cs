using Microsoft.EntityFrameworkCore;
using PatientFeedback.DTOs.Enums;
using PatientFeedback.DTOs.Response;

namespace PatientFeedback.Services;

public interface IAppointmentService
{
    Task<ApiResponse<GetAppointmentResponse>> GetAppointmentById(string appointmentId);

    Task<ApiResponse<GetAppointmentFeedbackResponse>> GetAppointmentFeedback(string appointmentId);
}

public class AppointmentService : IAppointmentService
{
    private readonly PatientFeedbackContext _context;
    
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
            .Include(appt => appt.AppointmentFeedback)
            .ThenInclude(af => af.AppointmentFeedbackQuestions)
            .ThenInclude(afq => afq.FeedbackQuestion)
            .FirstOrDefaultAsync(appt => appt.Id.ToString() == appointmentId);
        
        if (appointment is null)
        {
            response.ErrorCode = ErrorCode.NotFound;
            response.ErrorMessage = $"Appointment [{appointmentId}] not found";
            return response;
        }
        
        // TODO: replace placeholders with actual data
        var questions = 
            appointment.AppointmentFeedback.AppointmentFeedbackQuestions
                .Select(afq => afq.ToAppointmentFeedbackQuestionResponse()).ToList();
        
        response.Data = new GetAppointmentFeedbackResponse(appointment.Id.ToString(), 
            appointment.AppointmentType, 
            appointment.Status, 
            appointment.AppointmentFeedback.Id.ToString(),
            appointment.AppointmentFeedback.SubmittedDate,
            questions);
        return response;
    }
}