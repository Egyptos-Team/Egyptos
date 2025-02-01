using Egyptos.Domain.Entities.Transports;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class PrivateTransportConfiguration : IEntityTypeConfiguration<PrivateTransport>
{
    public void Configure(EntityTypeBuilder<PrivateTransport> builder)
    {
        builder.Property(x=>x.Name).HasMaxLength(50);
    }
}


public class BookingPrivateTransportConfiguration : IEntityTypeConfiguration<BookingPrivateTransport>
{
    public void Configure(EntityTypeBuilder<BookingPrivateTransport> builder)
    {
        builder.HasKey(x => new { x.UserId, x.PrivateTransportId });
    }
}
