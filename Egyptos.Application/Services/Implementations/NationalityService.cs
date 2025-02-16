using Egyptos.Application.Contracts.Nationality;
using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Egyptos.Application.Services.Implementations;

public class NationalityService(ApplicationDbContext _context) : INationalityService
{
    public async Task<IEnumerable<NationalityResponse>> GetAllAsync(string? nationality)
    {
        var nationalities = await _context.Nationalities.Where(x => nationality == null || x.Name.Contains(nationality))
            .OrderBy(x => x.Name).AsNoTracking().ToListAsync();
        return nationalities.Adapt<List<NationalityResponse>>();
    }

    public async Task<Result<NationalityResponse>> CreateAsync(NationalityRequest request)
    {
        if (await _context.Nationalities.AnyAsync(x => x.Name == request.Name))
            return Result.Failure<NationalityResponse>(NationalityErrors.AlreadyExists);

        var nationality = request.Adapt<Nationality>();
        await _context.Nationalities.AddAsync(nationality);
        await _context.SaveChangesAsync();

        return Result.Success(nationality.Adapt<NationalityResponse>());
    }

    public async Task<Result<NationalityResponse>> UpdateAsync(int id, NationalityRequest request)
    {
        var nationality = await _context.Nationalities.FindAsync(id);
        if (nationality == null)
            return Result.Failure<NationalityResponse>(NationalityErrors.NotFound);

        if( await _context.Nationalities.AnyAsync(x => x.Name == request.Name && x.Id != id))
            return Result.Failure<NationalityResponse>(NationalityErrors.AlreadyExists);

        nationality.Name = request.Name;
        await _context.SaveChangesAsync();

        return Result.Success(nationality.Adapt<NationalityResponse>());
    }

    public async Task<Result> DeleteAsync(int id)
    {
        var nationality = await _context.Nationalities.FindAsync(id);
        if (nationality == null)
            return Result.Failure(NationalityErrors.NotFound);

        _context.Nationalities.Remove(nationality);
        await _context.SaveChangesAsync();

        return Result.Success();
    }


}
