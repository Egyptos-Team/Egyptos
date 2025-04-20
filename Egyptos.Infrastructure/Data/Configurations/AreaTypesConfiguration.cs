using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class AreaTypesConfiguration : IEntityTypeConfiguration<AreaType>
{
    public void Configure(EntityTypeBuilder<AreaType> builder)
    {
        var areaTypes = new List<AreaType>
        {
            // Fixed artifacts: 30 1:30
            new AreaType 
            {
                Id=1,
                Name="Fixed artifacts"
            },
            //Archaeological sites: 20 31:50 
            new AreaType 
            {
                Id=2,
                Name="Archaeological sites"
            },
            //Sunken artifacts: 8 71:78
            new AreaType 
            {
                Id=3,
                Name="Sunken artifacts"
            },
            // Safari: 10 61:70
            new AreaType 
            {
                Id=4,
                Name="Safari"
            },
            // Sea and Nile Cruises: 10 51:60
            new AreaType 
            {
                Id=5,
                Name="Marine and Nile"
            },
            // Gblya: 10 81:90
            new AreaType 
            {
                Id=6,
                Name="Mountainous"
            },
            // Ryfya & 6by3ya W Astgmam: 10 91:100
            new AreaType 
            {
                Id=7,
                Name="Rural and natural"
            },
            //Museums: 22 101:122
            new AreaType 
            {
                Id=8,
                Name="Museums"
            }
        };
        builder.HasData(areaTypes);
    }
}
