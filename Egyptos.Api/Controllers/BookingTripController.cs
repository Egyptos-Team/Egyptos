using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.BookingTrip;
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

    [HttpPost("")]
    public async Task<IActionResult> Booking([FromBody] BookingTripRequest request)
    {
        var result = await _bookingTripService.BookATicket(User.GetUserId(), request);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }

    [HttpGet("")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _bookingTripService.GetAllAsync();

        return Ok(result);
    }

    [HttpGet("")]
    public async Task<IActionResult> BookedByUser()
    {
        var result = await _bookingTripService.BookedByUserAsync(User.GetUserId());

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> TripBookd([FromRoute] int id)
    {
        var result = await _bookingTripService.TripBookedAsync(id);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var result = await _bookingTripService.DeleteAsync(id);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }

}
