using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class TourGuideTripConfiguration : IEntityTypeConfiguration<TourGuideTrip>
{
    public void Configure(EntityTypeBuilder<TourGuideTrip> builder)
    {
        builder.HasKey(x => new { x.TripId, x.TourGuideId });
    }
}
