using Egyptos.Application.Contracts.Users;

namespace Egyptos.Application.Services.Interfaces;

public interface IUserService
{
    Task<IEnumerable<UserResponse>> GetAllAsync();
    Task<Result<string>> DeleteAsync(string email);
}
