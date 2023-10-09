using PatientFeedback.DTOs.ViewModels;

namespace PatientFeedback.Entities;

public class Appointment
{
    public Guid Id { get; set; }

    public string Status { get; set; } = null!;

    public string AppointmentType { get; set; } = null!;
    
    public Guid PatientId { get; set; }
    
    public Guid DoctorId { get; set; }
    
    public DateTime Start { get; set; }
    
    public DateTime End { get; set; }

    public virtual Patient Patient { get; set; } = null!;

    public virtual Doctor Doctor { get; set; } = null!;

    public virtual AppointmentFeedback AppointmentFeedback { get; set; } = null!;

    public virtual ICollection<Diagnosis> Diagnoses { get; set; } = new List<Diagnosis>();

    public AppointmentResponse ToAppointmentResponse()
    {
        return new AppointmentResponse(Id.ToString(), AppointmentType, Status, Start, End);
    }
}