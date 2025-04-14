using Egyptos.Api.Extensions;
using Egyptos.Application.Contracts.Users;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Egyptos.Api.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
[Authorize(Roles = DefaultRoles.Admin.Name)]
public class UsersController(IUserService _userService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll()
    {
        var result = await _userService.GetAllAsync();
        return Ok(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Add(CreateUserRequest request)
    {
        var result = await _userService.AddAsync(request);
        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpDelete("{email}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Delete(string email)
    {
        var result = await _userService.DeleteAsync(email);
        return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
    }

    [HttpGet("")]
    public async Task<IActionResult> GetAllBookings()
    {
        var result = await _userService.GetAllBookingsAsync(User.GetUserId());

        return Ok(result.Value);
    }
}
