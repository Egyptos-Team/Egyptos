using Egyptos.Domain.Entities;
using Egyptos.Domain.Entities.Identity;
using Egyptos.Domain.Entities.Transports;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Egyptos.Infrastructure.Data;

public class ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;
    public DbSet<Nationality> Nationalities { get; set; } = null!;
    public DbSet<TransportType> TransportTypes { get; set; } = null!;
    public DbSet<PrivateTransport> PrivateTransports { get; set; } = null!;
    public DbSet<PublicTransport> PublicTransports { get; set; } = null!;
    public DbSet<BookingPublicTransport> BookingPublicTransports { get; set; } = null!;
    public DbSet<BookingPrivateTransport> BookingPrivateTransports { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
