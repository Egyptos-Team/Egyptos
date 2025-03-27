using Egyptos.Application.Contracts.Area;
using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Egyptos.Application.Services.Implementations;

public class AreaService(ApplicationDbContext context, IFileService fileService) : IAreaService
{
    private readonly ApplicationDbContext _context = context;
    private readonly IFileService _fileService = fileService;

    public async Task<Result<List<AreaResponse>>> GetAllAsync()
    {
        var areas = await _context.Areas
            .Include(x=>x.AreaImages)
            .ProjectToType<AreaResponse>()
            .AsNoTracking()
            .ToListAsync();

        return Result.Success(areas);
    }

    public async Task<Result<AreaResponse>> GetAsync(int id)
    {
        var area = await _context.Areas
          .Where(x => x.Id == id)
          .Include(x=>x.AreaImages)
          .ProjectToType<AreaResponse>()
          .AsNoTracking()
          .FirstOrDefaultAsync();

        return area is null
            ? Result.Failure<AreaResponse>(AreaError.NotFound)
            : Result.Success(area);
    }
    public async Task<Result<AreaResponse>> CreateAsync(AreaRequest request)
    {
        if (await _context.Areas.AnyAsync(x => (x.Name.ToLower() == request.Name.ToLower() && x.Address.ToLower() == request.Address.ToLower())) )
            return Result.Failure<AreaResponse>(AreaError.DoublicatedTitle);

        if(! await _context.AreaTypes.AnyAsync(x=>x.Id==request.AreaTypeId))
            return Result.Failure<AreaResponse>(AreaTypeError.NotFound);
        #region MyRegion

        //var area = new Area   //go to mapping and ignore 
        //{
        //    Name=request.Name,
        //    Address=request.Address,
        //    Location=request.Location,
        //    AreaTypeId=request.AreaTypeId,
        //    ImageUrl=request.ImageUrl,
        //    Description=request.Description
        //}; 
        #endregion
        var area = request.Adapt<Area>();

        foreach (var image in request.AreaImages)
        {
            var imageUrl = await _fileService.UploadAsync(image, "AreaImages");
            area.AreaImages.Add(new AreaImage { ImageUrl = imageUrl });
        }

        await _context.AddAsync(area);
        await _context.SaveChangesAsync();

        return Result.Success(area.Adapt<AreaResponse>());
    }


    public async Task<Result> UpdateAsync(int id, AreaRequest request)
    {
        if (await _context.Areas.FindAsync(id) is not { } area)
            return Result.Failure(AreaError.NotFound);

        if (await _context.Areas.AnyAsync(x => (x.Name.ToLower() == request.Name.ToLower() && x.Address.ToLower() == request.Address.ToLower() && x.Id!=id)))
            return Result.Failure<AreaResponse>(AreaError.DoublicatedTitle);

        if (!await _context.AreaTypes.AnyAsync(x => x.Id == request.AreaTypeId))
            return Result.Failure<AreaResponse>(AreaTypeError.NotFound);

        area = request.Adapt(area);

        var currentImages = await _context.AreaImages
           .Where(x => x.AreaId == id)
           .ToListAsync();

        foreach (var image in currentImages)
        {
            area.AreaImages.Remove(image);
            await _fileService.DeleteAsync(image.ImageUrl);

        }

        foreach (var image in request.AreaImages)
        {
            var imageUrl = await _fileService.UploadAsync(image, "AreaImages");
            area.AreaImages.Add(new AreaImage { ImageUrl = imageUrl });
        }

        
        await _context.SaveChangesAsync();

        return Result.Success();
    }

    public async Task<Result> DeleteAsync(int id)
    {
        var isEx = await _context.Areas.AnyAsync(x => x.Id == id);
        if (!isEx)
            return Result.Failure(AreaError.NotFound);

        var currentImages = await _context.AreaImages
           .Where(x => x.AreaId == id)
           .ToListAsync();

        foreach (var image in currentImages)
        {
            await _fileService.DeleteAsync(image.ImageUrl);
        }

        _context.Areas.Remove(new Area { Id = id });

        await _context.SaveChangesAsync();

        return Result.Success();
    }

    
}
