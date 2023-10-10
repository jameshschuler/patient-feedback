using PatientFeedback.DTOs.ViewModels;

namespace PatientFeedback.DTOs.Response;

public record GetAppointmentsResponse(List<AppointmentFeedbackResponse> Appointments);