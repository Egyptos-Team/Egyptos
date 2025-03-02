using Egyptos.Application.Contracts.Roles;

namespace Egyptos.Application.Services.Interfaces;

public interface IRoleService
{
    Task<Result<IEnumerable<RoleResponse>>> GetAllAsync();
}
