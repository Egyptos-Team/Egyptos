using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.BookingTrip;
using Egyptos.Application.Contracts.Payment;
using Egyptos.Application.Services.Implementations;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class BookingTripController(IBookingTripService bookingTripService) : ControllerBase
{
    private readonly IBookingTripService _bookingTripService = bookingTripService;
    private static string? clientUrl;

    [HttpPost("")]
    [Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> Booking([FromBody] BookingTripRequest request)
    {
        var result = await _bookingTripService.BookATicket(User.GetUserId(), request);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }

    [HttpGet("")]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> GetAll()
    {
        var result = await _bookingTripService.GetAllAsync();

        return Ok(result);
    }

    [HttpGet("")]
    [Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> BookedByUser()
    {
        var result = await _bookingTripService.BookedByUserAsync(User.GetUserId());

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpGet("{id}")]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> TripBookd([FromRoute] int id)
    {
        var result = await _bookingTripService.TripBookedAsync(id);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var result = await _bookingTripService.DeleteAsync(id);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }

    [HttpPost("{bookingId}")]
    [Authorize]
    public async Task<IActionResult> OnlinePayment(int bookingId, [FromServices] IServiceProvider sp)
    {

        string? token = null;
        if (Request.Headers.TryGetValue("Authorization", out var authHeader))
        {
            var bearerToken = authHeader.ToString();
            if (bearerToken.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
            {
                token = bearerToken["Bearer ".Length..].Trim();
            }
        }

        var request = HttpContext.Request;
        var thisApiUrl = $"{request.Scheme}://{request.Host}";
        clientUrl = Request.Headers.Referer[0];

        var paymentRequest = new PaymentRequest
        {
            ApiUrl = thisApiUrl,
            ClientUrl = clientUrl!,
            SuccessRedirectUrl = $"{thisApiUrl}/api/BookingTrip/Success?bookingId={bookingId}&token={token}",
            CancelRedirectUrl = $"{thisApiUrl}/api/BookingTrip/Cancel/{bookingId}"
        };

        var result = await _bookingTripService.OnlinePaymentAsync(bookingId, paymentRequest);
        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [AllowAnonymous]
    [HttpGet("")]
    public async Task<IActionResult> Success([FromQuery] int bookingId,string token ,[FromServices] IServiceProvider sp)
    {

        var userId = token.GetUserIdFromToken();

        if (string.IsNullOrEmpty(userId))
            return BadRequest("invalid userId");
        
        var paymentStatus = await _bookingTripService.MarkAsPaidAsync(bookingId);

        if (!paymentStatus.IsSuccess)        
          return RedirectToAction("Cancel", new { bookingId });        

        return Redirect(clientUrl + "success");
    }

    [AllowAnonymous]
    [HttpGet("")]
    public IActionResult Cancel()
    {
        return BadRequest("Booking canceld successfully");
    }

}
