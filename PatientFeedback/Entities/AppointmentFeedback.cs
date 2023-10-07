namespace PatientFeedback.Entities;

public class AppointmentFeedback
{
    public Guid Id { get; set; }
    
    public DateTime? SubmittedDate { get; set; }
    
    public Guid AppointmentId { get; set; }

    public virtual Appointment Appointment { get; set; } = null!;

    public virtual ICollection<AppointmentFeedbackQuestion> AppointmentFeedbackQuestions { get; set; } = new List<AppointmentFeedbackQuestion>();
}