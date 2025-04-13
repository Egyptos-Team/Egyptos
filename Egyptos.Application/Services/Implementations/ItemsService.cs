using Egyptos.Application.Contracts.Items;
using Egyptos.Application.Contracts.Working;
using Egyptos.Domain.Entities;
using System.Collections.Generic;

namespace Egyptos.Application.Services.Implementations;
public class ItemsService(ApplicationDbContext context, IFileService fileService) : IItemsService
{
    private readonly ApplicationDbContext _context = context;
    private readonly IFileService _fileService = fileService;

    public async Task<Result<ItemsResponse>> AddAsync(int areaId, ItemsRequest request)
    {
        if (await _context.Areas.FindAsync(areaId) is not { } area)
            return Result.Failure<ItemsResponse>(AreaError.NotFound);

        var isExistingItemTitle = await _context.Items.AnyAsync(x => x.Title == request.Title);
        if (isExistingItemTitle)
            return Result.Failure<ItemsResponse>(ItemsErrors.DuplicatedItem);

        var item = request.Adapt<Item>();
        item.ImageUrl = await _fileService.UploadAsync(request.Image, "Items");
        item.AreaId = areaId;

        await _context.Items.AddAsync(item);
        await _context.SaveChangesAsync();

        return Result.Success(item.Adapt<ItemsResponse>());
    }
    public async Task<ICollection<ItemsResponse>> GetAllAsync() =>
        await _context.Items.ProjectToType<ItemsResponse>().ToListAsync();
    public async Task<Result<ItemsResponse>> GetAsync(int itemId)
    {
        if (await _context.Items.FindAsync(itemId) is not { } item)
            return Result.Failure<ItemsResponse>(ItemsErrors.ItemNotFount);

        return Result.Success(item.Adapt<ItemsResponse>());
    }
    public async Task<Result<List<ItemsResponse>>> GetAreaItemsAsync(int areaId)
    {
        if (await _context.Areas.FindAsync(areaId) is not { } area)
            return Result.Failure<List<ItemsResponse>> (AreaError.NotFound);

        var areaItems = await _context.Items.Where(x => x.AreaId == areaId).ProjectToType<ItemsResponse>().ToListAsync();

        return Result.Success(areaItems);
    }
    public async Task<Result> DeleteAsync(int itemId)
    {
        var isExstingItem = await _context.Items.AnyAsync(x => x.Id == itemId);
        if (!isExstingItem)
            return Result.Failure(ItemsErrors.ItemNotFount);

        _context.Items.Remove(new Item { Id = itemId });
        await _context.SaveChangesAsync();

        return Result.Success();
    }
}
