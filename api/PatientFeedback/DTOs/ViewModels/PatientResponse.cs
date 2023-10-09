using PatientFeedback.DTOs.Response;

namespace PatientFeedback.DTOs.ViewModels;

public record PatientResponse(string Id, bool Active, string FamilyName, string GivenName, string Gender, DateTime BirthDate, List<AddressResponse> Addresses, List<ContactResponse> Contacts)
{
    public string FullName => $"{GivenName} {FamilyName}";
};