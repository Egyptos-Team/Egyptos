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
            //athar thabta .... 3bdel7med 30
            new AreaType
            {
                Id=1,
                Name="Fixed artifacts"
            },
            //amakn atharya .... Alaa Maghraby 25
            new AreaType
            {
                Id=2,
                Name="Archaeological sites"
            },
            //athar ghar8a .... Nayira 8
            new AreaType
            {
                Id=3,
                Name="Sunken artifacts"
            },
            //Safari .... Rodina 10
            new AreaType
            {
                Id=4,
                Name="Safari"
            },
            //b7ryaw & nylya .... Marina 10
            new AreaType
            {
                Id=5,
                Name="Marine and Nile"
            },
            //gblya .... Marina 10
            new AreaType
            {
                Id=6,
                Name="Mountainous"
            },
            //ryfyaw & 6by3ya W astgmam .... Marina 10
            new AreaType
            {
                Id=7,
                Name="Rural and natural"
            }
        };
        builder.HasData();
    }
}
