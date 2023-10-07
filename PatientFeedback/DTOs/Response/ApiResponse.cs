using PatientFeedback.DTOs.Enums;

namespace PatientFeedback.DTOs.Response;

public class ApiResponse<T>
{
    public T? Data { get; set; }
    
    public ErrorCode? ErrorCode { get; set; }
    
    public string? ErrorMessage { get; set; }
}