using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.Area;
using Egyptos.Application.Contracts.Items;
using Egyptos.Application.Contracts.Working;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class ItemsController(IItemsService itemsService) : ControllerBase
{
    private readonly IItemsService _itemsService = itemsService;

    [HttpPost("{AreaId}")]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> Add([FromRoute] int AreaId, [FromForm] ItemsRequest request)
    {
        var result = await _itemsService.AddAsync(AreaId, request);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpGet("")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _itemsService.GetAllAsync();
        
        return Ok(result);
    }

    [HttpGet("{itemId}")]
    public async Task<IActionResult> Get([FromRoute] int itemId)
    {
        var result = await _itemsService.GetAsync(itemId);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpGet("{areaId}")]
    public async Task<IActionResult> GetAreaItems([FromRoute] int areaId)
    {
        var result = await _itemsService.GetAreaItemsAsync(areaId);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpDelete("{itemId}")]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> Delete([FromRoute] int itemId)
    {
        var result = await _itemsService.DeleteAsync(itemId);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }
}
