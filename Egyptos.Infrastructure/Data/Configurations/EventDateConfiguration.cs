using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Egyptos.Domain.Entities;

namespace Egyptos.Infrastructure.Data.Configurations;

public class EventDateConfiguration : IEntityTypeConfiguration<EventDate>
{
    public void Configure(EntityTypeBuilder<EventDate> builder)
    {
        var eventDate = new List<EventDate>
        {
            new EventDate
            {
                Id = 1,
                StartDate = new DateTime(2025, 1, 24, 15, 30, 0),
                EndDate = new DateTime(2025, 1, 24, 15, 30, 0),
                StartSubscription = new DateTime(2025, 1, 24, 15, 30, 0),
                EndSubscription = new DateTime(2025, 1, 24, 15, 30, 0),
                Description = "Description",
                Location = "Location",
                Price = 1500,
                EventId = 1,
            }
        };

        builder.HasData();
    }
}


public class EventDateImageConfiguration : IEntityTypeConfiguration<EventImage>
{    
    public void Configure(EntityTypeBuilder<EventImage> builder)
    {
        var eventImages = new List<EventImage>
        {
            new EventImage
            {
                Id = 1,
                ImageUrl="EventImages/kafdsjfkj.jpg",
                EventId = 1
            },
            new EventImage
            {
                Id = 2,
                ImageUrl="EventImages/kafdsjfkj.jpg",
                EventId = 1
            },
            new EventImage
            {
                Id = 3,
                ImageUrl="EventImages/kafdsjfkj.jpg",
                EventId = 1
            }
        };

        builder.HasData();
    }
}
