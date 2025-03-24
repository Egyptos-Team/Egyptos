using Egyptos.Domain.Entities;

namespace Egyptos.Application.Contracts.Transport.BookingPrivateTransport;

public class BookingPrivateTransportResponse
{
    public int Id { get; set; }
    public string Location { get; set; }
    public DateTime Start { get; set; }
    public DateTime? End { get; set; }
    public DateTime? PaymentDate { get; set; }

    public DateTime? PaymentCancel { get; set; }
    public double? TotalPrice { get; set; }
    public double PricePerHour { get; set; }
    public PrivateTransports.PrivateTransportResponse PrivateTransport { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public int PrivateTransportId { get; set; }
};
