using PatientFeedback.DTOs.Enums;

namespace PatientFeedback.Entities;

public class FeedbackQuestion
{
    public Guid Id { get; set; }
    
    // TODO: this could be configured to pull in other data variables (doctor info, patient info
    public string Text { get; set; } = null!; 
    
    public QuestionType QuestionType { get; set; }
}