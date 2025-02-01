using System.ComponentModel.DataAnnotations.Schema;
using Egyptos.Domain.Entities.Identity;

namespace Egyptos.Domain.Entities.Transports;

public class BookingPublicTransport
{
    public string UserId { get; set; } = null!;
    [ForeignKey(nameof(UserId))]
    public ApplicationUser ApplicationUser { get; set; } = null!;

    public int PublicTransportId { get; set; }
    public PublicTransport PublicTransport { get; set; } = null!;

}
