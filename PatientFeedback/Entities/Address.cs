using PatientFeedback.DTOs.ViewModels;

namespace PatientFeedback.Entities;

public class Address
{
    public Guid Id { get; set; }
    
    public string StreetAddress { get; set; } = null!;

    public string AddressType { get; set; } = null!;
    
    public Guid PatientId { get; set; }

    public AddressResponse ToAddressResponse()
    {
        return new AddressResponse(AddressType, StreetAddress);
    }
}