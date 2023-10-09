using PatientFeedback.DTOs.ViewModels;

namespace PatientFeedback.DTOs.Response;

public record GetAppointmentResponse(AppointmentResponse Appointment, PatientResponse Patient, DoctorResponse Doctor, List<DiagnosisResponse> Diagnoses);