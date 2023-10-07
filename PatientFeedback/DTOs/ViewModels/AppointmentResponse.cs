namespace PatientFeedback.DTOs.ViewModels;

public record AppointmentResponse(string Id, string Type, string Status, DateTime Start, DateTime End);