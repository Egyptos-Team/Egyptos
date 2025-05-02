using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.TripReview;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class TripReviewsController(ITripReviewService tripReviewService) : ControllerBase
{
    private readonly ITripReviewService _TripReviewService = tripReviewService;

    [HttpGet]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> GetAll()
    {
        var result = await _TripReviewService.GetAllAsync();
        return Ok(result);
    }

    [HttpGet]
    [Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> GetReviewsForUser()
    {
        var result = await _TripReviewService.GetAllForUserAsync(User.GetUserId());
        return Ok(result);
    }
    [HttpPost]
    //[Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> Add([FromForm] TripReviewRequest request)
    {
        var result = await _TripReviewService.AddAsync(User.GetUserId(), request);
        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpPut("{reviewId}")]
    //[Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> Update(int reviewId, [FromForm] TripReviewRequest request)
    {
        var result = await _TripReviewService.UpdateAsync(User.GetUserId(), reviewId, request);
        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }


    [HttpDelete("{reviewId}")]
    [Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> Delete(int reviewId)
    {
        var result = await _TripReviewService.DeleteAsync(reviewId);
        return result.IsSuccess ? Ok(result) : result.ToProblem();
    }
}
