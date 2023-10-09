using PatientFeedback.DTOs.Enums;

namespace PatientFeedback.DTOs.ViewModels;

public record AppointmentFeedbackQuestionResponse(string QuestionId, string QuestionName, string Text, QuestionType QuestionType, int Order, string? Value = null);