using System.Reflection.Metadata.Ecma335;
using Egyptos.Domain.Entities;
using Egyptos.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Egyptos.Infrastructure.Data;

public class ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;

    public DbSet<Area> Areas { get; set; }
    public DbSet<AreaImage> AreaImages { get; set; }
    public DbSet<AreaType> AreaTypes { get; set; }
    public DbSet<BookingTrip> BookingTrips { get; set; }
    public DbSet<PublicTransport> PublicTransports { get; set; }
    public DbSet<TourGuide> TourGuides { get; set; }
    public DbSet<TourGuideTrip> TourGuideTrips { get; set; }
    public DbSet<Trip> Trips { get; set; }
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<BookingHotel> BookingHotels { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<EventType> EventTypes { get; set; }
    public DbSet<EventDate> EventDates { get; set; }
    public DbSet<BookingEventDate> BookingEventDates { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(warnings =>
            warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }
}
