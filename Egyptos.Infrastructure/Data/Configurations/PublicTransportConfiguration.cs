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
    }
}
