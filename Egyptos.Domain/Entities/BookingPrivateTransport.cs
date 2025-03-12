using Egyptos.Domain.Entities.Identity;

namespace Egyptos.Domain.Entities;

public class BookingPrivateTransport
{
    public string UserId { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;

    public DateTime Start { get; set; }
    public DateTime? End { get; set; }

    public double? TotalPrice { get; set; }
   

    public DateTime? PaymentDate { get; set; }
    public DateTime? PaymentCancel { get; set; }

    public int PrivateTransportId { get; set; }
    public PrivateTransport PublicTransportation { get; set; } = null!;

}

public class BookingPrivateTransportRecuest
{
    public int PrivateTransportId { get; set; }
    public DateTime Start { get; set; }
    public DateTime? End { get; set; }

}
