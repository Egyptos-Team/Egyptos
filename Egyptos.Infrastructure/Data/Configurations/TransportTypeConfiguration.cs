using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class TransportTypeConfiguration : IEntityTypeConfiguration<TransportType>
{
    public void Configure(EntityTypeBuilder<TransportType> builder)
    {
        var transportTypes = new List<TransportType>
        {
            new TransportType
            {
                Id = 1,
                Name = "Car",
            },
            new TransportType
            {
                Id = 2,
                Name = "Bus",
            },
            new TransportType
            {
                Id = 3,
                Name = "Scoter",
            },
            new TransportType
            {
                Id = 4,
                Name = "bicycle",
            }
        };

        builder.HasData(transportTypes);
    }
}
