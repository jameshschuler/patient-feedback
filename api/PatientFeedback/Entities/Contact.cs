using PatientFeedback.DTOs.Enums;
using PatientFeedback.DTOs.ViewModels;

namespace PatientFeedback.Entities;

public class Contact
{
    public Guid Id { get; set; }

    public ContactSystem ContactSystem { get; set; }

    public ContactType? ContactType { get; set; }

    public string Value { get; set; } = null!;
    
    public Guid PatientId { get; set; }

    public ContactResponse ToContactResponse()
    {
        return new ContactResponse(Enum.GetName(typeof(ContactSystem), ContactSystem)!, Value, ContactType is null ? null : Enum.GetName(typeof(ContactType), ContactType));
    }
}