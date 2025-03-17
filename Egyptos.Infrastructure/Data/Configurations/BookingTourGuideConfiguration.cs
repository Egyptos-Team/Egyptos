using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class BookingTourGuideConfiguration : IEntityTypeConfiguration<BookingTourGuide>
{
    public void Configure(EntityTypeBuilder<BookingTourGuide> builder)
    {
    }
}
