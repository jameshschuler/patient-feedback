using PatientFeedback.DTOs.ViewModels;

namespace PatientFeedback.Entities;

public class Doctor
{
    public Guid Id { get; set; }

    public string GivenName { get; set; } = null!;
    
    public string FamilyName { get; set; } = null!;

    public DoctorResponse ToDoctorResponse()
    {
        return new DoctorResponse(Id.ToString(), FamilyName, GivenName);
    }
}