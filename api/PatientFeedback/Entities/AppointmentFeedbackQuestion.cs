using PatientFeedback.DTOs.ViewModels;

namespace PatientFeedback.Entities;

public class AppointmentFeedbackQuestion
{
    public Guid Id { get; set; }
    
    public int Order { get; set; }
    
    public Guid AppointmentFeedbackId { get; set; }

    public virtual AppointmentFeedback AppointmentFeedback { get; set; } = null!;
    
    public Guid FeedbackQuestionId { get; set; }

    public virtual FeedbackQuestion FeedbackQuestion { get; set; } = null!;
    
    public Guid? FeedbackAnswerId { get; set; }

    public virtual FeedbackAnswer? FeedbackAnswer { get; set; }

    public AppointmentFeedbackQuestionResponse ToAppointmentFeedbackQuestionResponse()
    {
        return new AppointmentFeedbackQuestionResponse(FeedbackQuestionId.ToString(), 
            FeedbackQuestion.QuestionName, FeedbackQuestion.Text, FeedbackQuestion.QuestionType, Order, FeedbackAnswer?.Value ?? "Not Provided");
    }
}