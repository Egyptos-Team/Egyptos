using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.EventDateContracts;
using Egyptos.Application.Contracts.EventType;
using Egyptos.Application.Services.Implementations;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventDatesController(IEventDateService eventDateService) : ControllerBase
{
    private readonly IEventDateService _eventDateService = eventDateService;

    [HttpPost("")]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> AddAsync([FromForm] CreateEventDateRequest request)
    {
        var result = await _eventDateService.AddAsync(request);

        return Ok();
    }

    [HttpGet("")]
    public async Task<IActionResult> GetAllAsync()
    {
        var result = await _eventDateService.GetAllAsync();

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute]int id)
    {
        var result = await _eventDateService.GetAsync(id);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpPut("{id}")]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> Update([FromRoute] int id, [FromForm] UpdateEventDateRequest request)
    {
        var result = await _eventDateService.UpdateAsync(id, request);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var result = await _eventDateService.DeleteAsync(id);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }
}
