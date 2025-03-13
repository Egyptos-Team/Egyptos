using Egyptos.Application.Contracts.Transport.TransportTypes;
using Egyptos.Domain.Entities;
using Egyptos.Domain.Errors.PrivateTransport;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace Egyptos.Application.Services.Implementations;

public class TransportTypeService(ApplicationDbContext context) : ITransportTypeService
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Result<List<TransportTypeResponse>>> GetAllAsync()
    {
        var types = await _context.TransportTypes
            .ProjectToType<TransportTypeResponse>()
            .ToListAsync();

        if (!types.Any())
            return Result.Failure<List<TransportTypeResponse>>(TransportTypeErrors.NotFound);

        return Result.Success(types);
    }

    public async Task<Result<TransportTypeResponse>> CreateAsync(TransportTypeRequest request)
    {
        var isExsit = await _context.TransportTypes.AnyAsync(x => x.Name.ToLower() == request.Name.ToLower());

        if (isExsit)
            return Result.Failure<TransportTypeResponse>(TransportTypeErrors.DoublicatedTitle);

        var type = request.Adapt<TransportType>();

        await _context.AddAsync(type);
        await _context.SaveChangesAsync();

        return Result.Success(type.Adapt<TransportTypeResponse>());
    }    
   
    public async Task<Result<TransportTypeResponse>> GetAsync(int id)
    {
        var type = await _context.TransportTypes.FindAsync(id);

        return type is not null
             ? Result.Success(type.Adapt<TransportTypeResponse>())
             : Result.Failure<TransportTypeResponse>(TransportTypeErrors.NotFound);
    }

    public async Task<Result> UpdateAsync(int id, TransportTypeRequest request)
    {
        var isExsit = await _context.TransportTypes.AnyAsync(x=>x.Name.ToLower() == request.Name.ToLower() && x.Id != id);

        if (isExsit)
            return Result.Failure<TransportTypeResponse>(TransportTypeErrors.DoublicatedTitle);

        var current = await _context.TransportTypes.FindAsync(id);

        if(current is null)
            return Result.Failure<TransportTypeResponse>(TransportTypeErrors.NotFound);

        current = request.Adapt(current);

        await _context.SaveChangesAsync();

        return Result.Success();

    }

    public async Task<Result>DeleteAsync(int id)
    {
        var current = await _context.TransportTypes.FindAsync(id);

        if (current is null)
            return Result.Failure(TransportTypeErrors.NotFound);

         _context.TransportTypes.Remove(current);

        await _context.SaveChangesAsync();

        return Result.Success();
    }
}
