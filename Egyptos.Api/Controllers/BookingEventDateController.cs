using System.Text;
using System.Text.Json;
using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.Payment;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class BookingEventDateController(IBookingEventDateService bookingEventDateService) : ControllerBase
{
    private readonly IBookingEventDateService _bookingEventDateService = bookingEventDateService;
    private static string? clientUrl;

    [HttpPost("{eventDateId}")]
    public async Task<IActionResult> Booking([FromRoute] int eventDateId)
    {
        var result = await _bookingEventDateService.BookATicket(User.GetUserId(), eventDateId);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }

    [HttpGet("")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _bookingEventDateService.GetAllAsync();

        return Ok(result);
    }

    [HttpPost("{bookingId}")]
    [Authorize]
    public async Task<IActionResult> OnlinePayment(int bookingId, [FromServices] IServiceProvider sp)
    {

        var request = HttpContext.Request;
        var thisApiUrl = $"{request.Scheme}://{request.Host}";
        clientUrl = Request.Headers.Referer[0];

        var paymentRequest = new PaymentRequest
        {
            ApiUrl = thisApiUrl,
            ClientUrl = clientUrl,
            SuccessRedirectUrl = $"{thisApiUrl}/api/BookingEventDate/Success?bookingId={bookingId}&userId={User.GetUserId()}",
            CancelRedirectUrl = $"{thisApiUrl}/api/BookingEventDate/Cancel/{bookingId}"
        };

        var result = await _bookingEventDateService.OnlinePaymentAsync(bookingId, User.GetUserId(), paymentRequest);
        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [AllowAnonymous]
    [HttpGet("")]
    public async Task<IActionResult> Success([FromQuery] int bookingId, [FromQuery] string userId, [FromServices] IServiceProvider sp)
    {
        var paymentStatus = await _bookingEventDateService.MarkAsPaidAsync(bookingId, userId);

        if (!paymentStatus.IsSuccess)
        {
            return RedirectToAction("Cancel", new { bookingId });
        }

        return Redirect(clientUrl + "success.html");
    }

    [AllowAnonymous]
    [HttpGet("")]
    public IActionResult Cancel()
    {
        return BadRequest("Booking canceld successfully");
    }

    [HttpGet("")]
    [Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> BookedByUser()
    {
        var result = await _bookingEventDateService.BookedByUserAsync(User.GetUserId());

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpGet("{id}")]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> EventBookd([FromRoute] int id)
    {
        var result = await _bookingEventDateService.EventBookedAsync(id);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpDelete("{eventDateId}")]
    public async Task<IActionResult> Delete([FromRoute] int eventDateId)
    {
        var result = await _bookingEventDateService.DeleteAsync(User.GetUserId(), eventDateId);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }
}
