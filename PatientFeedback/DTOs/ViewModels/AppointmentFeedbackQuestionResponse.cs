using PatientFeedback.DTOs.Enums;

namespace PatientFeedback.DTOs.ViewModels;

public record AppointmentFeedbackQuestionResponse(string Text, QuestionType QuestionType, int Order);