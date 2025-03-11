using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.Event;
using Egyptos.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventController(IEventService eventService) : ControllerBase
{
    private readonly IEventService _eventService = eventService;

    [HttpPost("")]
    public async Task<IActionResult> AddAsync([FromBody] CreateEventRequest request)
    {
        var result = await _eventService.AddAsync(request);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }

    //[HttpGet("")]
    //public async Task<IActionResult> GetAllAsync()
    //{
    //    var result = await _eventService.GetAllAsync();

    //    return Ok(result);
    //}

}
