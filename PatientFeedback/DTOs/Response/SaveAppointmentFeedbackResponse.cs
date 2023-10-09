using PatientFeedback.DTOs.ViewModels;

namespace PatientFeedback.DTOs.Response;

public record SaveAppointmentFeedbackResponse(List<QuestionAnswerResponse> QuestionAnswers);