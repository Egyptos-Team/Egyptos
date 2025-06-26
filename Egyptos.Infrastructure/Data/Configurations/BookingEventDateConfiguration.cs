using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Xml;

namespace Egyptos.Infrastructure.Data.Configurations;

public class BookingEventDateConfiguration : IEntityTypeConfiguration<BookingEventDate>
{
    public void Configure(EntityTypeBuilder<BookingEventDate> builder)
    {
        builder.HasKey(x => new { x.UserId, x.EventDateId });

        builder.Property(e => e.Id)
       .ValueGeneratedOnAdd()
       .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
    }
}
