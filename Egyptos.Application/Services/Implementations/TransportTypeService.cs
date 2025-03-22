using Egyptos.Application.Contracts.Transport.TransportTypes;
using Egyptos.Application.Services.Interfaces;
using Egyptos.Domain.Entities;
using Egyptos.Domain.Errors.PrivateTransport;
using Microsoft.EntityFrameworkCore;

namespace Egyptos.Application.Services.Implementations;

public class TransportTypeService(ApplicationDbContext context,IFileService fileService) : ITransportTypeService
{
    private readonly ApplicationDbContext _context = context;
    private readonly IFileService _fileService = fileService;

    public async Task<Result<List<TransportTypeResponse>>> GetAllAsync()
    {
        var types = await _context.TransportTypes
            .ProjectToType<TransportTypeResponse>()
            .ToListAsync();

        if (!types.Any())
            return Result.Failure<List<TransportTypeResponse>>(TransportTypeErrors.NotFound);

        return Result.Success(types);
    }
    public async Task<Result<TransportTypeResponseWithTransports>> GetAsync(int id)
    {
        var type = await _context.TransportTypes
            .Include(x => x.PrivateTransports)
            .Where(x => x.Id == id)
            .ProjectToType<TransportTypeResponseWithTransports>()
            .FirstOrDefaultAsync();

        return type is not null
             ? Result.Success(type)
             : Result.Failure<TransportTypeResponseWithTransports>(TransportTypeErrors.NotFound);
    }
    public async Task<Result<TransportTypeResponse>> CreateAsync(TransportTypeRequest request)
    {
        var isExsit = await _context.TransportTypes.AnyAsync(x => x.Name.ToLower() == request.Name.ToLower());

        if (isExsit)
            return Result.Failure<TransportTypeResponse>(TransportTypeErrors.DoublicatedTitle);

        var type = request.Adapt<TransportType>();

        var imageUrl = await _fileService.UploadAsync(request.ImageUrl, "PrivateTransportImages");
        type.ImageUrl = imageUrl;

        await _context.AddAsync(type);
        await _context.SaveChangesAsync();

        return Result.Success(type.Adapt<TransportTypeResponse>());
    }

   

    public async Task<Result> UpdateAsync(int id, TransportTypeRequest request)
    {
        var isExsit = await _context.TransportTypes.AnyAsync(x => x.Name.ToLower() == request.Name.ToLower() && x.Id != id);

        if (isExsit)
            return Result.Failure<TransportTypeResponse>(TransportTypeErrors.DoublicatedTitle);

        var current = await _context.TransportTypes.FindAsync(id);

        if (current is null)
            return Result.Failure<TransportTypeResponse>(TransportTypeErrors.NotFound);

        current = request.Adapt(current);
        var imageUrl = await _fileService.UploadAsync(request.ImageUrl, "PrivateTransportImages");
        current.ImageUrl = imageUrl;

        await _context.SaveChangesAsync();

        return Result.Success();

    }

    public async Task<Result> DeleteAsync(int id)
    {
        var current = await _context.TransportTypes.FindAsync(id);

        if (current is null)
            return Result.Failure(TransportTypeErrors.NotFound);

        _context.TransportTypes.Remove(current);

        await _context.SaveChangesAsync();

        return Result.Success();
    }
}
