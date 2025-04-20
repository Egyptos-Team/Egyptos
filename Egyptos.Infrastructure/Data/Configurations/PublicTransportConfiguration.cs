using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class PublicTransportConfiguration : IEntityTypeConfiguration<PublicTransport>
{
    public void Configure(EntityTypeBuilder<PublicTransport> builder)
    {
        builder.Property(p => p.SerialNumber)
            .ValueGeneratedNever();

        builder.HasIndex(p => p.SerialNumber)
            .IsUnique();

        var PublicTransport = new List<PublicTransport>
        {
            new  PublicTransport
            {
                Id = 1,
                Name = "Bus",
                Capacity = 50,
                ImageUrl = "PublicTransportmages/1.webp",
                SerialNumber = 1,
                IsAvailable = 1
            },
        };
        builder.HasData(PublicTransport);
    }
}
