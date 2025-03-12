using Egyptos.Application.Contracts.Transport.TransportTypes;
using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Egyptos.Application.Services.Implementations;

public class TransportTypeService(ApplicationDbContext context) : ITransportTypeService
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Result<TransportTypeResponse>> CreateAsync(TransportTypeRequest request,CancellationToken cancellationToken=default)
    {
        var IsExist = await _context.TransportTypes.AnyAsync(x => x.Name == request.Name, cancellationToken:cancellationToken);

        if (IsExist)
            return Result.Failure<TransportTypeResponse>(TransportTypeErrors.DoublicatedTransportTypeTitle);

        var type = request.Adapt<TransportType>();

        await _context.AddAsync(type, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        return Result.Success(type.Adapt<TransportTypeResponse>());
    }

    public async Task<Result<TransportTypeResponse>> GetAsync(int id, CancellationToken cancellationToken = default)
    {
        //1var type = await _context.TransportTypes.FindAsync(id, cancellationToken);
        throw new Exception();

    }
}
