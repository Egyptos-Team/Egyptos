using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.Nationality;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
[Authorize(Roles = DefaultRoles.Admin.Name)]
public class NationalitiesController(INationalityService _nationalityService) : ControllerBase
{
    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> GetAll(string? nationality)
    {
        var nationalities = await _nationalityService.GetAllAsync(nationality);
        return Ok(nationalities);
    }

    [HttpPost]
    public async Task<IActionResult> Create(NationalityRequest request)
    {
        var result = await _nationalityService.CreateAsync(request);
        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpPut]
    public async Task<IActionResult> Update(int id, NationalityRequest request)
    {
        var result = await _nationalityService.UpdateAsync(id, request);
        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _nationalityService.DeleteAsync(id);
        return result.IsSuccess ? Ok() : result.ToProblem();
    }

}
