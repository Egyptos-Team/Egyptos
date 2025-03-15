using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.BookingTourGuide;
using Egyptos.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
//[Authorize(Roles = DefaultRoles.Admin.Name)]
public class BookingTourGuideController(IBookingTourGuideService bookingTourGuideService) : ControllerBase
{
    private readonly IBookingTourGuideService _bookingTourGuideService = bookingTourGuideService;

    [HttpPost("")]
    public async Task<IActionResult> BookATicket([FromBody] BookingTourGuideRequest request)
    {
        var result = await _bookingTourGuideService.BookATicketAsync(User.GetUserId(), request);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }

    [HttpGet("")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _bookingTourGuideService.GetAllAsync();

        return Ok(result);
    }

    [HttpGet("BookedByUser")]
    public async Task<IActionResult> BookedByUser()
    {
        var result = await _bookingTourGuideService.BookedByUserAsync(User.GetUserId());

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> TourGuideBooked([FromRoute] int id)
    {
        var result = await _bookingTourGuideService.TourGuideBookedAsync(id);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    //[Authorize(Roles = DefaultRoles.Admin.Name)]
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var result = await _bookingTourGuideService.DeleteAsync(User.GetUserId(), id);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }

}
