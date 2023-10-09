namespace PatientFeedback.DTOs.Request;

public class SaveFeedbackRequest
{
    public string? AppointmentId { get; set; }
    
    public List<FeedbackQuestionAnswer>? QuestionAnswers { get; set; }
}

public class FeedbackQuestionAnswer
{
    public string? AppointmentFeedbackQuestionId { get; set; }
    
    public string? Value { get; set; }
}