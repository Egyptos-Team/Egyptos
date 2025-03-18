using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.EventType;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class EventTypeController(IEventTypeService eventTypeService) : ControllerBase
{
    private readonly IEventTypeService _eventTypeService = eventTypeService;

    [HttpPost("")]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> Add([FromBody] CreateEventTypeRequest request)
    {
        var result = await _eventTypeService.AddAsync(request);
        return result.IsSuccess ? CreatedAtAction(nameof(Get), new { id = result.Value?.Id }, result.Value)
                                : result.ToProblem();
    }

    [HttpGet("")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _eventTypeService.GetAllAsync();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        var result = await _eventTypeService.GetAsync(id);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpPut("{id}")]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateEventTypeRequest request)
    {
        var result = await _eventTypeService.UpdateAsync(id, request);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();                       
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var result = await _eventTypeService.DeleteAsync(id);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }
}
