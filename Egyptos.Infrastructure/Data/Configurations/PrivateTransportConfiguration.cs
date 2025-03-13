using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

class PrivateTransportConfiguration : IEntityTypeConfiguration<PrivateTransport>
{
    public void Configure(EntityTypeBuilder<PrivateTransport> builder)
    {
        var privateTransports = new List<PrivateTransport>
        {
            new PrivateTransport
            {
                Id = 1,
                Name = "Bmw M5",
                PricePerHour = 0.0,
                Description = "",
                ImageUrl = "PrivateTransports/Bmw-M5.jpg",
                Capacity = 4,
                Quantity = 2,
                TransportTypeId = 1
            },
            new PrivateTransport
            {
                Id = 2,
                Name = "",
                PricePerHour = 0.0,
                Description = "",
                ImageUrl = "",
                Capacity = 4,
                Quantity = 2,
                TransportTypeId = 1
            }
        };

        //builder.HasData(privateTransports);

    }
}
