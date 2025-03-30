using Egyptos.Application.Contracts.AreaWorking;
using Egyptos.Domain.Entities;
using System;
namespace Egyptos.Application.Services.Implementations;
internal class AreaWorkingService(ApplicationDbContext context) : IAreaWorkingService
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Result<AreaWorkingResponse>> AddAsync(AreaWorkingRequest request)
    {
        if(!await _context.Areas.AnyAsync(x => x.Id == request.AreaId))
            return Result.Failure<AreaWorkingResponse>(AreaError.NotFound);

        if (!await _context.Workings.AnyAsync(x => x.Id == request.WorkingId))
            return Result.Failure<AreaWorkingResponse>(WorkingErrors.WorkingNotFount);

        var isExistingAreaWorking = await _context.AreaWorkings.AnyAsync(x => x.AreaId == request.AreaId && x.WorkingId == request.WorkingId);
        if (isExistingAreaWorking)
            return Result.Failure<AreaWorkingResponse>(WorkingErrors.DuplicatedAreaWorking);

        var areaWorking = request.Adapt<AreaWorking>();

        await _context.AreaWorkings.AddAsync(areaWorking);
        await _context.SaveChangesAsync();

        return Result.Success(areaWorking.Adapt<AreaWorkingResponse>());
    }
    public async Task<ICollection<AreaWorkingResponse>> GetAllAsync() =>
        await _context.AreaWorkings.ProjectToType<AreaWorkingResponse>().ToListAsync();
    public async Task<Result> DeleteAsync(AreaWorkingRequest request)
    {
        var isExistingAreaWorking = await _context.AreaWorkings.AnyAsync(x => x.AreaId == request.AreaId && x.WorkingId == request.WorkingId);
        if (!isExistingAreaWorking)
            return Result.Failure<AreaWorkingResponse>(WorkingErrors.AreaWorkingNotFount);

        _context.AreaWorkings.Remove(new AreaWorking { AreaId = request.AreaId , WorkingId = request.WorkingId} );
        await _context.SaveChangesAsync();

        return Result.Success();
    }

}
