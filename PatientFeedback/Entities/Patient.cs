using PatientFeedback.DTOs.ViewModels;

namespace PatientFeedback.Entities;

public class Patient
{
    public Guid Id { get; set; }

    public string GivenName { get; set; } = null!;
    
    public string FamilyName { get; set; } = null!;
    
    public bool Active { get; set; }

    public string Gender { get; set; } = null!;
    
    public DateTime BirthDate { get; set; }

    public ICollection<Address> Addresses { get; set; } = new List<Address>();

    public ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public PatientResponse ToPatientResponse()
    {
        var contacts = Contacts.Select(c => c.ToContactResponse()).ToList();
        var addresses = Addresses.Select(a => a.ToAddressResponse()).ToList();
        
        return new PatientResponse(Id.ToString(), Active, FamilyName, GivenName, Gender, BirthDate, addresses, contacts);
    }
}