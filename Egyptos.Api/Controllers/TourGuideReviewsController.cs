using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.TourGuideReviews;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
[Authorize]
public class TourGuideReviewsController(ITourGuideReviewService _tourGuideReviewService) : ControllerBase
{
    [HttpGet]
    [Authorize(Roles = DefaultRoles.Admin.Name)]
    public async Task<IActionResult> GetAll()
    {
        var result = await _tourGuideReviewService.GetAllAsync();
        return Ok(result);
    }

    [HttpGet]
    [Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> GetReviewsForUser()
    {
        var result = await _tourGuideReviewService.GetAllForUserAsync(User.GetUserId());
        return Ok(result);
    }

    [HttpPost]
    //[Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> Add([FromForm]TourGuideReviewRequest request)
    {
        var result = await _tourGuideReviewService.AddAsync(User.GetUserId(), request);
        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpPut("{reviewId}")]
    //[Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> Update(int reviewId,[FromForm] TourGuideReviewRequest request)
    {
        var result = await _tourGuideReviewService.UpdateAsync(User.GetUserId(), reviewId, request);
        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpDelete("{reviewId}")]
    [Authorize(Roles = DefaultRoles.User.Name)]
    public async Task<IActionResult> Delete(int reviewId)
    {
        var result = await _tourGuideReviewService.DeleteAsync(reviewId);
        return result.IsSuccess ? Ok(result) : result.ToProblem();
    }
}
