using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class BookingEventDateConfiguration : IEntityTypeConfiguration<BookingEventDate>
{
    public void Configure(EntityTypeBuilder<BookingEventDate> builder)
    {
        builder.HasKey(x => new { x.UserId, x.EventDateId });
    }
}
