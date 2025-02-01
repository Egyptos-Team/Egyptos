using System.ComponentModel.DataAnnotations.Schema;
using Egyptos.Domain.Entities.Identity;

namespace Egyptos.Domain.Entities.Transports;

public class BookingPrivateTransport
{
    public string UserId { get; set; } = null!;
    [ForeignKey(nameof(UserId))]
    public ApplicationUser ApplicationUser { get; set; } = null!;

    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public double TotalPrice { get; set; }
    public int Quantity { get; set; }

    public int PrivateTransportId { get; set; }
    public PrivateTransport PublicTransportation { get; set; } = null!;

}
