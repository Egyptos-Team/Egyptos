using Egyptos.Application.Contracts.Users;

namespace Egyptos.Application.Contracts.BookingTrip;
public class BookingTripResponse
{
    public int Id { get; set; }
    public int NumberOfTickets { get; set; }
    public double TotalPrice { get; set; }
    public DateTime? PaymentDate { get; set; }
    public DateTime? CancelDate { get; set; }
    public TripResponse Trip { get; set; } = null!;
    public UserResponse User { get; set; } = null!;
   
}
