using Egyptos.Application.Contracts.Items;

namespace Egyptos.Application.Services.Interfaces;
public interface IItemsService
{
    Task<Result<ItemsResponse>> AddAsync(int areaId, ItemsRequest request);
    Task<ICollection<ItemsResponse>> GetAllAsync();
    Task<Result<ItemsResponse>> GetAsync(int itemId);
    Task<Result<List<ItemsResponse>>> GetAreaItemsAsync(int areaId);
    Task<Result> DeleteAsync(int itemId);
}
