using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.Event;
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

    [HttpPost("{eventDateId}")]
    public async Task<IActionResult> Booking([FromRoute]int eventDateId)
    {
        var result = await _bookingEventDateService.BookATicket(User.GetUserId(),eventDateId);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }

    [HttpGet("")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _bookingEventDateService.GetAllAsync();

        return Ok(result);
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
