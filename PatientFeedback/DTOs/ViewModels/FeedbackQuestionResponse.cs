using PatientFeedback.DTOs.Enums;

namespace PatientFeedback.DTOs.ViewModels;

public record FeedbackQuestionResponse(string Text, int Order, QuestionType QuestionType);