using Egyptos.Application.Contracts.Nationality;

namespace Egyptos.Application.Services.Interfaces;

public interface INationalityService
{
    Task<IEnumerable<NationalityResponse>> GetAllAsync(string? nationality);
    Task<Result<NationalityResponse>> CreateAsync(NationalityRequest request);
    Task<Result<NationalityResponse>> UpdateAsync(int id, NationalityRequest request);
    Task<Result> DeleteAsync(int id);
}
