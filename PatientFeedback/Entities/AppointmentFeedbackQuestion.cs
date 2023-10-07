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

    public virtual FeedbackAnswer? FeedbackAnswer { get; set; } = null!;

    public AppointmentFeedbackQuestionResponse ToAppointmentFeedbackQuestionResponse()
    {
        return new AppointmentFeedbackQuestionResponse(FeedbackQuestion.Text, FeedbackQuestion.QuestionType, Order);
    }
}