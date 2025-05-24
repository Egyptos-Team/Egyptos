using Egyptos.Domain.Entities.Identity;

namespace Egyptos.Domain.Entities;

public class BookingTrip
{
    public int Id { get; set; } 
    public int NumberOfTickets { get; set; }
    public double TotalPrice { get; set; }
    public int TripId { get; set; }
    public Trip Trip { get; set; } = null!;

    public string UserId { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;
}
