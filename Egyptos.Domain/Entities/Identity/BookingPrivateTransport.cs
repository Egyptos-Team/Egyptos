using System.ComponentModel.DataAnnotations.Schema;

namespace Egyptos.Domain.Entities.Identity;

public class BookingPrivateTransport
{
    public string UserId { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;

    public DateTime Start { get; set; }
    public DateTime End { get; set; }

    public double TotalPrice { get; set; }
    public int Quantity { get; set; }

    public int PrivateTransportId { get; set; }
    public PrivateTransport PublicTransportation { get; set; } = null!;

}
