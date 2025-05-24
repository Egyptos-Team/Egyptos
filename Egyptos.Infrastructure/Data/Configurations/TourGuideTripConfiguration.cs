using Egyptos.Domain.Entities;
using Egyptos.Infrastructure.Data.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class TourGuideTripConfiguration : IEntityTypeConfiguration<TourGuideTrip>
{
    public void Configure(EntityTypeBuilder<TourGuideTrip> builder)
    {
        builder.HasKey(x => new { x.TripId, x.TourGuideId });

        int x = 1;
        var tourGuideTrips = new List<TourGuideTrip>();

        for (int tripId = 1; tripId <= 60; tripId++)
        {
            tourGuideTrips.Add(new TourGuideTrip
            {
                TripId = tripId,
                TourGuideId = x++
            });
            if (x == 20) x = 1;
        }

        if (x == 20) x = 1;

        for (int tripId = 61; tripId <= 150; tripId++)
        {
            if (tripId == 79 || tripId == 80)
                continue;

            tourGuideTrips.Add(new TourGuideTrip
            {
                TripId = tripId,
                TourGuideId = x++
            });
            if (x == 20) x = 1;
        }

        builder.HasData(tourGuideTrips);
    }
}
