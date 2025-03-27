using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.PrivateTransportReview;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class PrivateTransportReviewsController(IPrivateTransportReviewService privateTransportReviewService) : ControllerBase
{
    private readonly IPrivateTransportReviewService _privateTransportReviewService = privateTransportReviewService;

    [HttpPost("")]
    [Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> Add([FromBody] PrivateTransportReviewRequest request)
    {
        var result = await _privateTransportReviewService.AddAsync(User.GetUserId(),request);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpGet("")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _privateTransportReviewService.GetAllAsync();

        return Ok(result);
    }

    [HttpGet("")]
    [Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> GetAllForUser()
    {
        var result = await _privateTransportReviewService.GetAllForUserAsync(User.GetUserId());

        return Ok(result);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> Update([FromRoute] int id,[FromBody] PrivateTransportReviewRequest request)
    {
        var result = await _privateTransportReviewService.UpdateAsync(User.GetUserId(), id, request);

        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = $"{DefaultRoles.User.Name},{DefaultRoles.Admin.Name}")]
    public async Task<IActionResult> Delete([FromRoute]int id)
    {
        var result = await _privateTransportReviewService.DeleteAsync(id);

        return result.IsSuccess ? Ok() : result.ToProblem();
    }
}
