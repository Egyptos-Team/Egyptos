using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.Payment;
using Egyptos.Application.Contracts.Transport.BookingPrivateTransport;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
[Authorize]
public class BookingPrivateTransportsController(IBookingPrivateTransportService booking) : ControllerBase
{
    private readonly IBookingPrivateTransportService _booking = booking;
    private static string? clientUrl;


    [HttpGet("")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> GetAll()
    {
        var result = await _booking.GetAllAsync();

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }


    [HttpGet("")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> GetAllForUser()
    {
        var result = await _booking.GetAllForUserAsync(User.GetUserId());

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }


    [HttpGet("{bookingId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> GetById(int bookingId)
    {
        var result = await _booking.GetAsync(bookingId);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }



    [HttpPost("")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> Create([FromBody] BookingPrivateTransportRequest request)
    {
        var result = await _booking.CreateAsync(User.GetUserId(), request);

        return result.IsSuccess
             ? CreatedAtAction(nameof(GetById), new { bookingId = result.Value.Id }, result.Value)
             : result.ToProblem();
    }

    [HttpPost("{bookingId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> OnlinePayment(int bookingId, [FromServices] IServiceProvider sp)
    {

        clientUrl = Request.Headers.Referer[0];

        var server = sp.GetRequiredService<IServer>();
        var serverAddressesFeature = server.Features.Get<IServerAddressesFeature>();
        var thisApiUrl = serverAddressesFeature!.Addresses.First();

        var paymentRequest = new PaymentRequest
        {
            ApiUrl = thisApiUrl!,
            ClientUrl = Request.Headers.Referer[0]!,
            SuccessRedirectUrl = thisApiUrl + "/api/BookingPrivateTransports/Success/" + bookingId,
            CancelRedirectUrl = thisApiUrl + "/api/Payment/Cancel/" + bookingId
        };

        var result = await _booking.OnlinePaymentAsync(bookingId, paymentRequest);
        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [AllowAnonymous]
    [HttpGet("{bookingId}")]
    public async Task<IActionResult> Success(int bookingId, [FromServices] IServiceProvider sp)
    {
        var paymentStatus = await _booking.MarkAsPaidAsync(bookingId);

        if (!paymentStatus.IsSuccess)
        {
            return RedirectToAction("Cancel", new { bookingId });
        }

        return Redirect(clientUrl + "success.html");
    }

    //public IActionResult Cancel(int bookingid)
    //{
    //    throw new NotImplementedException();
    //}

    [HttpPut("{bookingId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> Update(int bookingId, [FromBody] BookingPrivateTransportRequest request)
    {
        var result = await _booking.UpdateAsync(bookingId, request);

        return result.IsSuccess
            ? NoContent()
            : result.ToProblem();
    }


    [HttpPut("{bookingId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> EndBookingManual(int bookingId)
    {
        var result = await _booking.EndBookingManualAsync(bookingId);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpPut("{bookingId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    [Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> CancelBooking(int bookingId)
    {
        var result = await _booking.CancelBookingAsync(bookingId);
        return result.IsSuccess ? NoContent() : result.ToProblem();
    }

}
