namespace Egyptos.Application.Contracts.Transport.BookingPrivateTransport;

public class BookingPrivateTransportResponse
{
    public int Id { get; set; }
    public DateTime Start { get; set; }
    public DateTime? End { get; set; }
    public double? TotalPrice { get; set; }
    public double PricePerHour { get; set; }
    public string UserId { get; set; } = null!;
    public int PrivateTransportId { get; set; }
};
