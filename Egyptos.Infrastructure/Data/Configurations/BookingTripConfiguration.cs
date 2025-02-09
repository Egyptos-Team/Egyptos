using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class BookingTripConfiguration : IEntityTypeConfiguration<BookingTrip>
{
    public void Configure(EntityTypeBuilder<BookingTrip> builder)
    {
        builder.HasKey(x => new { x.UserId, x.TripId });
    }
}
