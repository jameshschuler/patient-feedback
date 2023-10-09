using Microsoft.AspNetCore.Mvc;
using PatientFeedback.DTOs.Enums;
using PatientFeedback.DTOs.Request;
using PatientFeedback.DTOs.Response;
using PatientFeedback.DTOs.ViewModels;
using PatientFeedback.Services;

namespace PatientFeedback.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AppointmentController : ControllerBase
{
    private readonly IAppointmentService _appointmentService;
    
    public AppointmentController(IAppointmentService appointmentService)
    {
        _appointmentService = appointmentService;
    }

    [HttpGet("{appointmentId}")]
    public async Task<ActionResult<GetAppointmentResponse>> Get([FromRoute] string appointmentId)
    {
        try
        {
            var appointmentResponse = await _appointmentService.GetAppointmentById(appointmentId);

            if (appointmentResponse.Data is null)
            {
                return NotFound();
            }
            
            return Ok(appointmentResponse);
        }
        catch (Exception)
        {
            return Problem(statusCode: 500);
        }
    }
    
    [HttpGet("{appointmentId}/feedback")]
    public async Task<ActionResult<GetAppointmentFeedbackResponse>> GetAppointmentFeedback([FromRoute] string appointmentId)
    {
        try
        {
            var appointmentFeedbackResponse = await _appointmentService.GetAppointmentFeedback(appointmentId);

            if (appointmentFeedbackResponse.ErrorCode is ErrorCode.NotFound)
            {
                return NotFound(appointmentFeedbackResponse);
            }
            
            return Ok(appointmentFeedbackResponse);
        }
        catch (Exception)
        {
            return Problem(statusCode: 500);
        }
    }

    [HttpPost("feedback")]
    public async Task<ActionResult<SaveAppointmentFeedbackResponse>> SaveAppointmentFeedback([FromBody] SaveFeedbackRequest request)
    {
        try
        {
            var response = await _appointmentService.SaveAppointmentFeedback(request);

            return response.ErrorCode switch
            {
                ErrorCode.NotFound => NotFound(response),
                ErrorCode.BadRequest => BadRequest(response),
                _ => Created(new Uri($"/appointment/{request.AppointmentId}/feedback"), response)
            };
        }
        catch (Exception)
        {
            return Problem(statusCode: 500);
        }
    }
}