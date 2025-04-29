using Egyptos.Application.Contracts.AreaType;

namespace Egyptos.Application.Services.Implementations;

public class AreaTypeService(ApplicationDbContext context) : IAreaTypeService
{
    private readonly ApplicationDbContext _context = context;


    public async Task<Result<List<AreaTypeResponse>>> GetAllAsync()
    {
        var types = await _context.AreaTypes
            .Include(x => x.Areas)
            .ProjectToType<AreaTypeResponse>()
            .AsNoTracking()
            .ToListAsync();
        return Result.Success(types);
    }

    public async Task<Result<List<ListAreaTypeResponse>>> GetListAsync()
    {
        var types = await _context.AreaTypes
            .ProjectToType<ListAreaTypeResponse>()
            .AsNoTracking()
            .ToListAsync();

        return Result.Success(types);
    }

    public async Task<Result<AreaTypeResponse>> GetAsync(int id)
    {
        var type = await _context.AreaTypes
            .Where(x => x.Id == id)
            .Include(x => x.Areas)
            .ProjectToType<AreaTypeResponse>()
            .AsNoTracking()
            .FirstOrDefaultAsync();

        return type is null
            ? Result.Failure<AreaTypeResponse>(AreaTypeError.NotFound)
            : Result.Success(type);
    }

    public async Task<Result<AreaTypeResponse>> CreateAsync(AreaTypeRequest request)
    {
        if (await _context.AreaTypes.AnyAsync(x => x.Name == request.Name))
            return Result.Failure<AreaTypeResponse>(AreaTypeError.DoublicatedTitle);

        var type = request.Adapt<AreaType>();
        await _context.AreaTypes.AddAsync(type);
        await _context.SaveChangesAsync();

        return Result.Success(type.Adapt<AreaTypeResponse>());


    }

    public async Task<Result> UpdateAsync(int id, AreaTypeRequest request)
    {
        if (await _context.AreaTypes.FindAsync(id) is not { } type)
            return Result.Failure<AreaTypeResponse>(AreaTypeError.NotFound);

        if (await _context.AreaTypes.AnyAsync(x => x.Name.ToLower() == request.Name.ToLower() && id != x.Id))
            return Result.Failure<AreaTypeResponse>(AreaTypeError.DoublicatedTitle);

        type = request.Adapt(type);
        await _context.SaveChangesAsync();

        return Result.Success();
    }

    public async Task<Result> DeleteAsync(int id)
    {
        if (await _context.AreaTypes.FindAsync(id) is not { } type)
            return Result.Failure(AreaTypeError.NotFound);

        _context.AreaTypes.Remove(type);

        await _context.SaveChangesAsync();

        return Result.Success();
    }
}
