using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class TourGuideTripConfiguration : IEntityTypeConfiguration<TourGuideTrip>
{
    public void Configure(EntityTypeBuilder<TourGuideTrip> builder)
    {
        builder.HasKey(x => new { x.TripId, x.TourGuideId });

        var random = new Random();
        var tourGuideTrips = new List<TourGuideTrip>();

        for (int tripId = 1; tripId <= 60; tripId++)
        {
            int randomGuideId = random.Next(1, 10); 
            tourGuideTrips.Add(new TourGuideTrip
            {
                TripId = tripId,
                TourGuideId = randomGuideId
            });
        }

        for (int tripId = 61; tripId <= 122; tripId++)
        {
            if (tripId == 79 || tripId == 80)
                continue;

            int randomGuideId = random.Next(12, 18);
            tourGuideTrips.Add(new TourGuideTrip
            {
                TripId = tripId,
                TourGuideId = randomGuideId
            });
        }

        builder.HasData(tourGuideTrips);
    }
}
