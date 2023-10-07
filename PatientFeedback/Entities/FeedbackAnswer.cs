namespace PatientFeedback.Entities;

public class FeedbackAnswer
{
    public Guid Id { get; set; }
    
    public string Value { get; set; } = null!;
}