using Egyptos.Application.Contracts.Transport.BookingPrivateTransport;
using Egyptos.Application.Contracts.Transport.PrivateTransports;
using Egyptos.Domain.Entities;
using Egyptos.Domain.Errors.PrivateTransport;
using Microsoft.EntityFrameworkCore;

namespace Egyptos.Application.Services.Implementations;

public class BookingPrivateTransportService(ApplicationDbContext context) : IBookingPrivateTransportService
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Result<BookingPrivateTransportResponse>> CreateAsync(string userId , BookingPrivateTransportRequest request)
    {
        var isExsist = await _context.PrivateTransports.AnyAsync(x => x.Id == request.PrivateTransportId);

        if(!isExsist)
            return Result.Failure<BookingPrivateTransportResponse>(PrivateTransportError.NotFound);

        var isAvilable = await _context.PrivateTransports.AnyAsync( x => (x.Id == request.PrivateTransportId) && x.IsAvailable);

        if (!isAvilable)
            return Result.Failure<BookingPrivateTransportResponse>(PrivateTransportError.NotAvilable);

        var book = request.Adapt<BookingPrivateTransport>();

        book.UserId = userId;

        await _context.BookingPrivateTransports.AddAsync(book);
        await _context.SaveChangesAsync();

        return Result.Success(book.Adapt<BookingPrivateTransportResponse>());
    }    

    public async Task<Result<BookingPrivateTransportResponse>> GetAsync(int id)
    {
        var booking = await _context.BookingPrivateTransports
            .Where(x => x.Id == id)
            .Include(x => x.User)
            .Include(x => x.PrivateTransport)
            .ProjectToType<BookingPrivateTransportResponse>()
            .FirstOrDefaultAsync();

        if (booking is null)
            return Result.Failure<BookingPrivateTransportResponse>(BookingPrivateTransportError.NotFound);

        var bookingMapped = booking.Adapt<BookingPrivateTransportResponse>();        

        return Result.Success(bookingMapped);
       
    }
   
}
