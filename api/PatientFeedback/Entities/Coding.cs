using PatientFeedback.DTOs.ViewModels;

namespace PatientFeedback.Entities;

public class Coding
{
    public Guid Id { get; set; }

    public string System { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;
    
    public Guid DiagnosisId { get; set; }

    public CodingResponse ToCodingResponse()
    {
        return new CodingResponse(Code, Name, System);
    }
}