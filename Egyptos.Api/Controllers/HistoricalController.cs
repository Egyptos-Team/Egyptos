using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.Historical;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class HistoricalController(IHistoricalService historicalService) : ControllerBase
{
    private readonly IHistoricalService _historicalService = historicalService;

    [HttpGet("")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _historicalService.GetAllAsync();

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        var result = await _historicalService.GetAsync(id);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpPut("{id}")]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> Update([FromRoute] int id, [FromForm] UpdateHistoricalRequest request)
    {
        var result = await _historicalService.UpdateAsync(id, request);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var result = await _historicalService.DeleteAsync(id);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }
}
