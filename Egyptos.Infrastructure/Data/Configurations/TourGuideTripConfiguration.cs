using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class TourGuideTripConfiguration : IEntityTypeConfiguration<TourGuideTrip>
{
    public void Configure(EntityTypeBuilder<TourGuideTrip> builder)
    {
        builder.HasKey(x => new { x.TripId, x.TourGuideId });

        var tourGuideTrips = new List<TourGuideTrip>();

        int totalTrips = 122; 
        int totalTourGuides = 19;

        for (int tripId = 1; tripId <= totalTrips; tripId++)
        {
            if(tripId == 79 || tripId == 80 || tripId == 12)
                continue;

            int tourGuideId = ((tripId - 1) % totalTourGuides) + 1;

            tourGuideTrips.Add(new TourGuideTrip
            {
                TripId = tripId,
                TourGuideId = tourGuideId
            });
        }

        builder.HasData(tourGuideTrips);
    }
}
