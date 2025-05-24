namespace Egyptos.Application.Contracts.BookingTrip;
public class TripResponse
{
    public int Id { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public DateTime BackTime { get; set; }
    public double Price { get; set; }
    public int AvailableSeats { get; set; }
    public bool IsActive { get => DateTime.UtcNow < DepartureTime && AvailableSeats > 0; set { } }
    public ICollection<TripProgram> TripPrograms { get; set; } = [];
}
