using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.Area;
using Egyptos.Application.Contracts.AreaType;
using Egyptos.Application.Contracts.EventDateContracts;
using Egyptos.Application.Services.Implementations;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class AreasController(IAreaService areaService) : ControllerBase
{
    private readonly IAreaService _areaService = areaService;

    [HttpGet("")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAll()
    {
        var result = await _areaService.GetAllAsync();

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _areaService.GetAsync(id);

        return result.IsSuccess
            ? Ok(result.Value)
            : result.ToProblem();
    }


    [HttpPost("")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Create([FromForm] AreaRequest request)
    {
        var result = await _areaService.CreateAsync(request);

        return result.IsSuccess
             ? CreatedAtAction(nameof(Get), new { id = result.Value.Id }, result.Value)
             : result.ToProblem();
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> Update([FromRoute] int id, [FromForm] AreaRequest request)
    {
        var result = await _areaService.UpdateAsync(id, request);

        return result.IsSuccess ? NoContent() : result.ToProblem();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete( int id)
    {
        var result = await _areaService.DeleteAsync(id);

        return result.IsSuccess ?NoContent() : result.ToProblem();
    }


}
