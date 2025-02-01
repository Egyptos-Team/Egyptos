
using Egyptos.Domain.Entities.Transports;
using Microsoft.AspNetCore.Identity;

namespace Egyptos.Domain.Entities.Identity;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Sex { get; set; } = null!;
    public string? NationalId { get; set; }

    public int NationalityId { get; set; }
    public Nationality Nationality { get; set; } = null!;
    public string Address { get; set; } = null!;

    public virtual ICollection<BookingPublicTransport> BookingPublicTransports { get; set; } = [];
    public virtual ICollection<BookingPrivateTransport> BookingPrivateTransports { get; set; } = [];
}
