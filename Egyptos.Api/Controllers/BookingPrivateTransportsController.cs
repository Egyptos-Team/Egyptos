using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.Transport.BookingPrivateTransport;
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
    
    [HttpGet]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _booking.GetAsync(id);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpPost("")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult>Create([FromBody]BookingPrivateTransportRequest request)
    {
        var result = await _booking.CreateAsync(User.GetUserId(), request);

        return result.IsSuccess
             ? CreatedAtAction(nameof(GetById), new { id = result.Value.Id }, result.Value)
             : result.ToProblem();
    }

}
