namespace PatientFeedback.DTOs.ViewModels;

public record DiagnosisResponse(string Id, DateTime? LastUpdated, string Status, List<CodingResponse> Codings);