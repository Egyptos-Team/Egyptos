using Egyptos.Application.Contracts.AreaType;

namespace Egyptos.Application.Services.Interfaces;

public interface IAreaTypeService
{
    Task<Result<List<AreaTypeResponse>>> GetAllAsync();
    Task<Result<AreaTypeResponse>> GetAsync(int id);
    Task<Result<List<ListAreaTypeResponse>>> GetListAsync();
    Task<Result<AreaTypeResponse>> CreateAsync(AreaTypeRequest request);
    Task<Result> UpdateAsync(int id, AreaTypeRequest request);
    Task<Result> DeleteAsync(int id);
}
