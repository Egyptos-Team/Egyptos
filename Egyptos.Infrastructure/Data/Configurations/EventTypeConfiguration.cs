using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Egyptos.Infrastructure.Data.Configurations;

public class EventTypeConfiguration : IEntityTypeConfiguration<EventType>
{
    public void Configure(EntityTypeBuilder<EventType> builder)
    {
        var eventTypes = new List<EventType>
        {
            new EventType
            {
                Id = 1,
                Name = "EventType1"
            },
            new EventType
            {
                Id = 2,
                Name = "EventType2"
            },
            new EventType
            {
                Id = 3,
                Name = "EventType3"
            }
        };

        builder.HasData();
    }
}
