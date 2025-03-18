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
                 Name = "Entertainment"
             },
             new EventType
             {
                 Id = 2,
                 Name = "Historical and Cultural"
             },
             new EventType
             {
                 Id = 3,
                 Name = "Religious"
             },
             new EventType
             {
                 Id =4 ,
                 Name = "Festival"
             },
             new EventType
             {
                 Id = 5,
                 Name = "Art"
             }
        };

        builder.HasData(eventTypes);
    }
}
