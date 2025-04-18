using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Egyptos.Infrastructure.Data.Configurations;
public class WorkingConfiguration : IEntityTypeConfiguration<Working>
{
    public void Configure(EntityTypeBuilder<Working> builder)
    {
        var workings = new List<Working>
        {
            new Working
            {
                Id = 1,
                Day = "Saturday",
                StartTime = new TimeOnly(12, 0),
                EndTime = new TimeOnly(20, 0)
            },
            new Working
            {
                Id = 2,
                Day = "Sunday",
                StartTime = new TimeOnly(8, 0),
                EndTime = new TimeOnly(20, 0)
            },
            new Working
            {
                Id = 3,
                Day = "Monday",
                StartTime = new TimeOnly(8, 0),
                EndTime = new TimeOnly(20, 0)
            },
            new Working
            {
                Id = 4,
                Day = "Tuesday",
                StartTime = new TimeOnly(8, 0),
                EndTime = new TimeOnly(20, 0)
            },
            new Working
            {
                Id = 5,
                Day = "Wednesday",
                StartTime = new TimeOnly(8, 0),
                EndTime = new TimeOnly(20, 0)
            },
            new Working
            {
                Id = 6,
                Day = "Thursday",
                StartTime = new TimeOnly(8, 0),
                EndTime = new TimeOnly(20, 0)
            },
            new Working
            {
                Id = 7,
                Day = "Friday",
                StartTime = new TimeOnly(13, 0),
                EndTime = new TimeOnly(20, 0)
            }
        };
        builder.HasData(workings);
    }
}
