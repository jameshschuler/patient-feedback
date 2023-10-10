namespace PatientFeedback.DTOs.ViewModels;

public record AppointmentFeedbackResponse(string AppointmentId, string AppointmentType, string Status, DateTime? SubmittedDate);