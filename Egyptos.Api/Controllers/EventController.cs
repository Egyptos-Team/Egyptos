using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.Event;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventController(IEventService eventService) : ControllerBase
{
    private readonly IEventService _eventService = eventService;

    [Authorize(Roles = DefaultRoles.Admin.Name)]
    [HttpPost("")]
    public async Task<IActionResult> AddAsync([FromBody] CreateEventRequest request)
    {
        var result = await _eventService.AddAsync(request);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }

    [HttpGet("")]
    public async Task<IActionResult> GetAllAsync()
    {
        var result = await _eventService.GetAllAsync();

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute] int id)
    {
        var result = await _eventService.GetAsync(id);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [Authorize(Roles = DefaultRoles.Admin.Name)]
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync([FromRoute] int id, UpdateEventRequest request)
    {
        var result = await _eventService.UpdateAsync(id, request);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [Authorize(Roles = DefaultRoles.Admin.Name)]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute] int id)
    {
        var result = await _eventService.DeleteAsync(id);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }
}
