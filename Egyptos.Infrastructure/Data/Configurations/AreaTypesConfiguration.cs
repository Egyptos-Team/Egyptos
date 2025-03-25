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
            // asar tabta
            // amakn asarya
            // asar 3arqa
            // spary
            // ba7rya
            // GBALYA
            // RYFAYE AND TABYA WA ASTGMAM
            new AreaType
            {
                Id=1,
                Name=""
            },
            new AreaType
            {
                Id=2,
                Name=""
            }
        };
        builder.HasData();
    }
}
