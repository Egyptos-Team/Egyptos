using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Egyptos.Infrastructure.Data.Configurations;

public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        var events = new List<Event>
        {
            new Event
            {
                Id = 1,
                Name = "Event1Name",
                Description = "Event1Description" ,
                EventTypeId = 1 
            },
            new Event
            {
                Id = 2,
                Name = "Event2Name",
                Description = "Event2Description" ,
                EventTypeId = 1
            },
            new Event
            {
                Id = 3,
                Name = "Event3Name",
                Description = "Event3Description" ,
                EventTypeId = 2
            }
        };

        builder.HasData();
    }
}