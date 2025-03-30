using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.AreaWorking;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;  
[Route("api/[controller]/[action]")]
[ApiController]
public class AreaWorkingController(IAreaWorkingService areaWorkingService) : ControllerBase
{
    private readonly IAreaWorkingService _areaWorkingService = areaWorkingService;

    [HttpPost("")]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> Add([FromBody] AreaWorkingRequest request)
    {
        var result = await _areaWorkingService.AddAsync(request);
        
        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpGet("")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _areaWorkingService.GetAllAsync();

        return Ok(result);
    }

    [HttpDelete("")]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> Delete([FromBody] AreaWorkingRequest request)
    {
        var result = await _areaWorkingService.DeleteAsync(request);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }

}
