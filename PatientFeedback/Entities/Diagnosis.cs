using PatientFeedback.DTOs.ViewModels;

namespace PatientFeedback.Entities;

public class Diagnosis
{
    public Guid Id { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string Status { get; set; } = null!;
    
    public Guid AppointmentId { get; set; }

    public virtual Appointment Appointment { get; set; } = null!;

    public ICollection<Coding> Codings { get; set; } = new List<Coding>();

    public DiagnosisResponse ToDiagnosisResponse()
    {
        var codings = Codings.Select(c => c.ToCodingResponse()).ToList();
        return new DiagnosisResponse(Id.ToString(), LastUpdated, Status, codings);
    }
}