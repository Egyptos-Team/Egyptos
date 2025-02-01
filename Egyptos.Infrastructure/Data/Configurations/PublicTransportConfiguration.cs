using Egyptos.Domain.Entities;
using Egyptos.Domain.Entities.Transports;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class PublicTransportConfiguration : IEntityTypeConfiguration<PublicTransport>
{
    public void Configure(EntityTypeBuilder<PublicTransport> builder)
    {
        builder.Property(x => x.Name)
            .HasMaxLength(100);
    }
}


public class BookingPublicTransportConfiguration : IEntityTypeConfiguration<BookingPublicTransport>
{
    public void Configure(EntityTypeBuilder<BookingPublicTransport> builder)
    {
        builder.HasKey(x => new { x.UserId, x.PublicTransportId });
    }
}
