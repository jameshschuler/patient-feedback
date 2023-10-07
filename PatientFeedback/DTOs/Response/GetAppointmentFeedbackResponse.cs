using PatientFeedback.DTOs.ViewModels;

namespace PatientFeedback.DTOs.Response;

public record GetAppointmentFeedbackResponse(string AppointmentId, string AppointmentType, string Status, string AppointmentFeedbackId, DateTime? SubmittedDate, List<AppointmentFeedbackQuestionResponse> Questions);