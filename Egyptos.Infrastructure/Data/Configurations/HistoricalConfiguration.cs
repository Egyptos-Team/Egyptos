using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Egyptos.Infrastructure.Data.Configurations;
//
public class HistoricalConfiguration : IEntityTypeConfiguration<Historical>
{
    public void Configure(EntityTypeBuilder<Historical> builder)
    {
        var historucal = new List<Historical>
        {
            new Historical
            {
                Id = 1,
                Title = "Some Title",
                Date = "Some Date",
                Description = "Some Description",
                ImageUrl = "HistoricalImages/Bmw-M5.jpg",
            }
        };

        builder.HasData();
    }
}

public class HistoricalImagesConfiguration : IEntityTypeConfiguration<HistoricalImage>
{
    public void Configure(EntityTypeBuilder<HistoricalImage> builder)
    {
        var historicalImage = new List<HistoricalImage>
        {
            new HistoricalImage
            {
                Id = 1,
                ImageUrl = "HistoricalImages/Bmw-M5.jpg",
                HistoricalId = 1
            },
            new HistoricalImage
            {
                Id = 2,
                ImageUrl = "HistoricalImages/Bmw-M5.jpg",
                HistoricalId = 1
            },
            new HistoricalImage
            {
                Id = 3,
                ImageUrl = "HistoricalImages/Bmw-M5.jpg",
                HistoricalId = 1

            }
        };
        builder.HasData();

    }
}
