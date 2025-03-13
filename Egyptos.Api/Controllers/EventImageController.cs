using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.EventImages;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = DefaultRoles.Admin.Name)]

public class EventImageController(IEventImageService eventImageService) : ControllerBase
{
    private readonly IEventImageService _eventImageService = eventImageService;

    [HttpPost("")]
    public async Task<IActionResult> Add([FromForm] CreateEventImageRequest request)
    {
        var result = await _eventImageService.AddAsync(request);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }

    [HttpGet("")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _eventImageService.GetAllAsync();

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        var result = await _eventImageService.GetAsync(id);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var result = await _eventImageService.DeleteAsync(id);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }
}
