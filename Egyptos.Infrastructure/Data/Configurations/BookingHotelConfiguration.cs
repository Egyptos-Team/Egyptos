using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class BookingHotelConfiguration : IEntityTypeConfiguration<BookingHotel>
{
    public void Configure(EntityTypeBuilder<BookingHotel> builder)
    {
        builder.HasKey(x => new { x.UserId, x.HotelId });
    }
}
