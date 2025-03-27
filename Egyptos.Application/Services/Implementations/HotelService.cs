using Egyptos.Application.Contracts.Hotels;
using Egyptos.Application.Contracts.Transport.TransportTypes;
using Egyptos.Domain.Errors.PrivateTransport;

namespace Egyptos.Application.Services.Implementations;

public class HotelService(ApplicationDbContext context,IFileService fileService) : IHotelService
{
    private readonly ApplicationDbContext _context = context;
    private readonly IFileService _fileService = fileService;

    public async Task<Result<List<HotelResponse>>> GetAllAsync()
    {
        var hotels = await _context.Hotels
            .ProjectToType<HotelResponse>()
            .ToListAsync();
        if (!hotels.Any())
            return Result.Failure<List<HotelResponse>>(HotelError.NotFount);

        return Result.Success(hotels);
    }

    public async Task<Result<HotelResponse>> GetAsync(int id)
    {
        var type = await _context.Hotels.FindAsync(id);

        return type is not null
             ? Result.Success(type.Adapt<HotelResponse>())
             : Result.Failure<HotelResponse>(HotelError.NotFount);
    }

    public async Task<Result<HotelResponse>> CreateAsync(HotelRequest request)
    {
        var isExsist = await _context.Hotels.AnyAsync(x => x.Location == request.Location);

        if (isExsist)
            return Result.Failure<HotelResponse>(HotelError.Doublicated);

        var hotel = request.Adapt<Hotel>();

        var imageUrl = await _fileService.UploadAsync(request.ImageUrl, "Hotels");

        hotel.ImageUrl = imageUrl ;

        await _context.Hotels.AddAsync(hotel);
        await _context.SaveChangesAsync();

        return Result.Success(hotel.Adapt<HotelResponse>());
    }

    public async Task<Result> UpdateAsync(int id, HotelRequest request)
    {
        var isExsit = await _context.Hotels.AnyAsync(x => x.Location == request.Location && x.Id != id);

        if (isExsit)
            return Result.Failure<HotelResponse>(HotelError.Doublicated);

        var hotel = await _context.Hotels.FindAsync(id);

        if (hotel is null)
            return Result.Failure<HotelResponse>(HotelError.NotFount);

        hotel = request.Adapt(hotel);

        var imageUrl = await _fileService.UploadAsync(request.ImageUrl, "Hotels");

        hotel.ImageUrl = imageUrl;

        await _context.SaveChangesAsync();

        return Result.Success();

    }

    public async Task<Result> DeleteAsync(int id)
    {
        var hotel = await _context.Hotels.FindAsync(id);

        if (hotel is null)
            return Result.Failure(HotelError.NotFount);

        _context.Hotels.Remove(hotel);

        await _context.SaveChangesAsync();

        return Result.Success();
    }
}
