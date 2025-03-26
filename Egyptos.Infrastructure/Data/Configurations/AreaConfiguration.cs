using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class AreaConfiguration : IEntityTypeConfiguration<Area>
{
    public void Configure(EntityTypeBuilder<Area> builder)
    {
        var areas = new List<Area>
        {
           new Area{
                 Id=1,
                 Name="",
                 Description="",// biiiiiiiiiiiiiiiiiiiiig
                 Location="",
                 Address="",
                 ImageUrl="AreaImages/xx.jpg",
                 AreaTypeId=1,
            },
           new Area{
                 Id=2,
                 Name="",
                 Description="",// biiiiiiiiiiiiiiiiiiiiig
                 Location="",
                 Address="",
                 ImageUrl="AreaImages/xx.jpg",
                 AreaTypeId=1,
           },
        };
        builder.HasData();
    }
}
