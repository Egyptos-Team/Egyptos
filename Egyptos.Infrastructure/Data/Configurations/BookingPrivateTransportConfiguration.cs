using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class BookingPrivateTransportConfiguration : IEntityTypeConfiguration<BookingPrivateTransport>
{
    public void Configure(EntityTypeBuilder<BookingPrivateTransport> builder)
    {
        builder.HasKey(x => new { x.UserId, x.PrivateTransportId });
    }
}
