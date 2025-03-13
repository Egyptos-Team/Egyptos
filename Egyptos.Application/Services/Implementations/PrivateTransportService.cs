using Egyptos.Application.Contracts.Transport.PrivateTransports;
using Egyptos.Application.Contracts.Transport.TransportTypes;
using Egyptos.Domain.Entities;
using Egyptos.Domain.Errors.PrivateTransport;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Egyptos.Application.Services.Implementations;

public class PrivateTransportService(ApplicationDbContext context, IFileService fileService) : IPrivateTransportService
{
    private readonly ApplicationDbContext _context = context;
    private readonly IFileService _fileService = fileService;

    public async Task<Result<List<PrivateTransportResponse>>> GetAllAsync()
    {
        var types = await _context.PrivateTransports
            .ProjectToType<PrivateTransportResponse>()
            .ToListAsync();

        if (!types.Any())
            return Result.Failure<List<PrivateTransportResponse>>(PrivateTransportError.NotFound);

        return Result.Success(types);
    }

    public async Task<Result<PrivateTransportResponse>> GetAsync(int id)
    {
        var type = await _context.PrivateTransports.FindAsync(id);

        return type is not null
             ? Result.Success(type.Adapt<PrivateTransportResponse>())
             : Result.Failure<PrivateTransportResponse>(PrivateTransportError.NotFound);
    }
    public async Task<Result<PrivateTransportResponse>> CreateAsync(PrivateTransportRequest request)
    {
        var isExsit = await _context.PrivateTransports.AnyAsync(x => x.Name.ToLower() == request.Name.ToLower());
        if (isExsit)
            return Result.Failure<PrivateTransportResponse>(PrivateTransportError.DoublicatedTitle);

        var privateTransport = new PrivateTransport
        {
             Name = request.Name,
             PricePerHour = request.PricePerHour,
             Description = request.Description,
             Capacity = request.Capacity,
             Quantity = request.Quantity,
             TransportTypeId = request.TransportTypeId
        };

        var imageUrl = await _fileService.UploadAsync(request.ImageUrl, "PrivateTransportImages");
        privateTransport.ImageUrl = imageUrl ;


        await _context.AddAsync(privateTransport);
        await _context.SaveChangesAsync();

        return Result.Success(privateTransport.Adapt<PrivateTransportResponse>());

    }

  
    public async Task<Result> UpdateAsync(int id, PrivateTransportRequest request)
    {
        var isExsit = await _context.PrivateTransports.AnyAsync(x => x.Name.ToLower() == request.Name.ToLower() && x.Id != id);

        if (isExsit)
            return Result.Failure<PrivateTransportResponse>(PrivateTransportError.DoublicatedTitle);

        var type = await _context.PrivateTransports.FindAsync(id);

        if (type is null)
            return Result.Failure(TransportTypeErrors.NotFound);

        type = request.Adapt(type);

        var imageUrl = await _fileService.UploadAsync(request.ImageUrl, "PrivateTransportImages");

        type.ImageUrl = imageUrl;

        await _context.SaveChangesAsync();

        return Result.Success();
    }

    public async Task<Result> DeleteAsync(int id)
    {
        var type = await _context.PrivateTransports.FindAsync(id);

        if (type is null)
            return Result.Failure(TransportTypeErrors.NotFound);

        _context.PrivateTransports.Remove(type);

        await _context.SaveChangesAsync();

        return Result.Success();
    }

}
