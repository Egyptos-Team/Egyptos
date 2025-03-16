using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.Transport.BookingPrivateTransport;
using Egyptos.Application.Contracts.Transport.TransportTypes;
using Egyptos.Application.Services.Implementations;
using Egyptos.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
[Authorize]
public class BookingPrivateTransportsController(IBookingPrivateTransportService booking) : ControllerBase
{
    private readonly IBookingPrivateTransportService _booking = booking;


    [HttpGet("")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAll()
    {
        var result = await _booking.GetAllAsync();

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }


    [HttpGet("")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAllForUser()
    {
        var result = await _booking.GetAllForUserAsync(User.GetUserId());

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }


    [HttpGet("{bookingId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById( int bookingId)
    {
        var result = await _booking.GetAsync(bookingId);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

   

    [HttpPost("")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult>Create([FromBody]BookingPrivateTransportRequest request)
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
    public async Task<IActionResult> OnlinePayment(int bookingId)
    {
        var result = await _booking.OnlinePaymentAsync(bookingId, User.GetUserId());
        return result.IsSuccess ? Ok() : result.ToProblem();
    }

    [HttpPut("{bookingId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update( int bookingId, [FromBody] BookingPrivateTransportRequest request)
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
    public async Task<IActionResult> EndBookingManual(int bookingId)
    {
        var result = await _booking.EndBookingManualAsync(bookingId);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpPut("{bookingId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CancelBooking( int bookingId)
    {
        var result = await _booking.CancelBookingAsync(bookingId);
        return result.IsSuccess ? NoContent() : result.ToProblem();
    }


   




}
