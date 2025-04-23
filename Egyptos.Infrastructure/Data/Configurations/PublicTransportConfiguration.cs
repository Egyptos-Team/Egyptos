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
        // Fixed artifacts: 30 1:30  (BUS)
        // Archaeological sites: 20 31:50  (BUS)
        // Sea and Nile Cruises: 10 51:60 (Yacht,Boat,Jeep)
        // Safari: 10 61:70 (?????? ????? ???????) 
        // Sunken artifacts: 8 71:78 (BUS)
        // Gblya: 10 81:90 (?????? ????? ???????)
        // Ryfya & 6by3ya W Astgmam: 10 91:100 (BUS)
        // Museums: 22 101:122 (BUS) 
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
        builder.HasData();
    }
}
