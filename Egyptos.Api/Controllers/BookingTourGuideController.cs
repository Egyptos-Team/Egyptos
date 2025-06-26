using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.BookingTourGuide;
using Egyptos.Application.Contracts.Payment;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class BookingTourGuideController(IBookingTourGuideService bookingTourGuideService) : ControllerBase
{
    private readonly IBookingTourGuideService _bookingTourGuideService = bookingTourGuideService;
    private static string? clientUrl;

    [HttpPost("")]
   // [Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> BookATicket([FromBody] BookingTourGuideRequest request)
    {
        var result = await _bookingTourGuideService.BookATicketAsync(User.GetUserId(), request);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpGet("")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _bookingTourGuideService.GetAllAsync();

        return Ok(result);
    }

    [HttpGet("")]
    [Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> BookedByUser()
    {
        var result = await _bookingTourGuideService.BookedByUserAsync(User.GetUserId());

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpGet("{id}")]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> TourGuideBookedForAdmin([FromRoute] int id)
    {
        var result = await _bookingTourGuideService.TourGuideBookedAsync(id);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpGet("")]
    [Authorize(Roles = DefaultRoles.TourGuide.Name)]
    public async Task<IActionResult> TourGuideBookedForTourGuide()
    {
        var result = await _bookingTourGuideService.TourGuideBookedAsync(User.GetUserId());

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpDelete("{bookingId}")]
    [Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> Delete(int bookingId)
    {
        var result = await _bookingTourGuideService.DeleteAsync(User.GetUserId(),bookingId);

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
            SuccessRedirectUrl = $"{thisApiUrl}/api/BookingTourGuide/Success?bookingId={bookingId}&token={token}",
            CancelRedirectUrl = $"{thisApiUrl}/api/BookingTourGuide/Cancel/{bookingId}"
        };

        var result = await _bookingTourGuideService.OnlinePaymentAsync(bookingId,paymentRequest);
        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [AllowAnonymous]
    [HttpGet("")]
    public async Task<IActionResult> Success([FromQuery] int bookingId,  [FromServices] IServiceProvider sp)
    {

       

        var paymentStatus = await _bookingTourGuideService.MarkAsPaidAsync(bookingId);

        if (!paymentStatus.IsSuccess)
            return RedirectToAction("Cancel", new { bookingId });

        return Redirect(clientUrl + "success.html");
    }

    [AllowAnonymous]
    [HttpGet("")]
    public IActionResult Cancel()
    {
        return BadRequest("Booking canceld successfully");
    }

}
