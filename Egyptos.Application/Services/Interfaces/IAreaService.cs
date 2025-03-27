using Egyptos.Application.Contracts.Area;
using Egyptos.Application.Contracts.AreaType;

namespace Egyptos.Application.Services.Interfaces;

public interface IAreaService
{
    Task<Result<List<AreaResponse>>> GetAllAsync();
    Task<Result<AreaResponse>> GetAsync(int id);

    Task<Result<AreaResponse>> CreateAsync(AreaRequest request);
    Task<Result> UpdateAsync(int id, AreaRequest request);
    Task<Result> DeleteAsync(int id);

}
