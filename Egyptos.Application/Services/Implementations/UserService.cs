using Egyptos.Application.Contracts.Nationality;
using Egyptos.Application.Contracts.Users;
using Egyptos.Domain.Consts;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Egyptos.Application.Services.Implementations;

public class UserService(UserManager<ApplicationUser> _userManager,ApplicationDbContext _context) : IUserService
{
    public async Task<IEnumerable<UserResponse>> GetAllAsync()
    {
        var users = await _userManager.Users
            .ToListAsync();

        var userResponses = new List<UserResponse>();

        foreach (var user in users)
        {
            var roles = await _userManager.GetRolesAsync(user);

            var userResponse = user.Adapt<UserResponse>();
            userResponse.Roles = await _userManager.GetRolesAsync(user);

            userResponses.Add(userResponse);
        }

        return userResponses;
    }

    public async Task<Result<string>> DeleteAsync(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user is null)
            return Result.Failure<string>(UserErrors.UserNotFound);

        var result = await _userManager.DeleteAsync(user);

        return !result.Succeeded
            ? Result.Failure<string>(new Error("BadRequest", result.Errors.First().Description , StatusCodes.Status400BadRequest))
            : Result.Success("User deleted successfully");
    }
}
