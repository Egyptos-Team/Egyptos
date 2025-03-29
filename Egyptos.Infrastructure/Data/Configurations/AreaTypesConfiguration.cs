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
            new AreaType 
            {
                Id=1,
                Name="Fixed artifacts"
            },
            new AreaType 
            {
                Id=2,
                Name="Archaeological sites"
            },
            new AreaType 
            {
                Id=3,
                Name="Sunken artifacts"
            },
            new AreaType 
            {
                Id=4,
                Name="Safari"
            },
            new AreaType 
            {
                Id=5,
                Name="Marine and Nile"
            },
            new AreaType 
            {
                Id=6,
                Name="Mountainous"
            },
            new AreaType 
            {
                Id=7,
                Name="Rural and natural"
            },
            new AreaType 
            {
                Id=8,
                Name="Museums"
            }
        };
        builder.HasData(areaTypes);
    }
}
