using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.Hotels;
using Egyptos.Application.Contracts.Transport.TransportTypes;
using Egyptos.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class HotelsController(IHotelService hotelService) : ControllerBase
{
    private readonly IHotelService _hotelService = hotelService;

    [HttpGet("")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAll()
    {
        var result = await _hotelService.GetAllAsync();

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        var result = await _hotelService.GetAsync(id);

        return result.IsSuccess
            ? Ok(result.Value)
            : result.ToProblem();
    }

    [HttpPost("")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> Create([FromForm] HotelRequest request)
    {
        var result = await _hotelService.CreateAsync(request);

        return result.IsSuccess
            ? CreatedAtAction(nameof(Get), new { id = result.Value?.Id }, result.Value)
            : result.ToProblem();
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(int id, [FromForm] HotelRequest request)
    {
        var result = await _hotelService.UpdateAsync(id, request);

        return result.IsSuccess
            ? NoContent()
            : result.ToProblem();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _hotelService.DeleteAsync(id);
        return result.IsSuccess
          ? NoContent()
          : result.ToProblem();
    }
}
