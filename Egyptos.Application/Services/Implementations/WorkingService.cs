using Egyptos.Application.Contracts.Event;
using Egyptos.Application.Contracts.Working;
using Microsoft.Extensions.Logging;

namespace Egyptos.Application.Services.Implementations;
public class WorkingService(ApplicationDbContext context) : IWorkingService
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Result<WorkingResponse>> AddAsync(WorkingRequest request)
    {
        var isExistingWorking = await _context.Workings.AnyAsync(x => x.Day == request.Day && x.StartTime == request.StartTime && x.EndTime == request.EndTime);
        if (isExistingWorking)
            return Result.Failure<WorkingResponse>(WorkingErrors.DuplicatedWorking);

        var working = request.Adapt<Working>();

        await _context.Workings.AddAsync(working);
        await _context.SaveChangesAsync();

        return Result.Success(working.Adapt<WorkingResponse>());
    }
    public async Task<ICollection<WorkingResponse>> GetAllAsync() => 
        await _context.Workings.ProjectToType<WorkingResponse>().ToListAsync();
    public async Task<Result<WorkingResponse>> GetAsync(int workingId)
    {
        if(await _context.Workings.FindAsync(workingId) is not { } working)
            return Result.Failure<WorkingResponse>(WorkingErrors.WorkingNotFount);

        return Result.Success(working.Adapt<WorkingResponse>());
    }
    public async Task<Result<WorkingResponse>> UpdateAsync(int workingId, WorkingRequest request)
    {
        if (await _context.Workings.FindAsync(workingId) is not { } working)
            return Result.Failure<WorkingResponse>(WorkingErrors.WorkingNotFount);

        var isExistingWorking = await _context.Workings.AnyAsync(x => x.Day == request.Day && x.StartTime == request.StartTime && x.EndTime == request.EndTime && x.Id != workingId);
        if (isExistingWorking)
            return Result.Failure<WorkingResponse>(WorkingErrors.DuplicatedWorking);

        working = request.Adapt(working);
        await _context.SaveChangesAsync();

        return Result.Success(working.Adapt<WorkingResponse>());
    }
    public async Task<Result> DeleteAsync(int workingId)
    {
        var isExstingWorking = await _context.Workings.AnyAsync(x => x.Id == workingId);
        if (!isExstingWorking)
            return Result.Failure(WorkingErrors.WorkingNotFount);

        _context.Workings.Remove(new Working { Id = workingId });
        await _context.SaveChangesAsync();

        return Result.Success();
    }

}
