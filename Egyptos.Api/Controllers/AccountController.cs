using System.ComponentModel.DataAnnotations;
using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.Users;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
[Authorize]
public class AccountController(IUserService _userService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Profile()
    {
        var result = await _userService.GetProfileAsync(User.GetUserId());
        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateProfile(UpdateProfileRequest request)
    {
        var result = await _userService.UpdateProfileAsync(User.GetUserId(), request);
        return result.IsSuccess ? Ok() : result.ToProblem();
    }

    [HttpPut]
    public async Task<IActionResult> ChangeImage([FromForm] ChangeProfileImageRequest image)
    {
        var result = await _userService.ChangeImageAsync(User.GetUserId(), image);
        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpPut]
    public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest request)
    {
        var result = await _userService.ChangePasswordAsync(User.GetUserId(), request);
        return result.IsSuccess ? Ok() : result.ToProblem();
    }

}
