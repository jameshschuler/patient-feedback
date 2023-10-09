using PatientFeedback.DTOs.Enums;

namespace PatientFeedback.Entities;

public class FeedbackQuestion
{
    public Guid Id { get; set; }
    
    public string Text { get; set; } = null!;

    public string QuestionName { get; set; } = null!;
    
    public QuestionType QuestionType { get; set; }
}