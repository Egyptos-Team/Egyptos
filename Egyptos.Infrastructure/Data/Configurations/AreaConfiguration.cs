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
                 Id=31,
                 Name="",
                 Description="",// biiiiiiiiiiiiiiiiiiiiig
                 Location="",
                 Address="Cairo",
                 ImageUrl="AreaImages/15.jpg",
                 AreaTypeId=2, 
           },
           new Area{
                 Id=32,
                 Name="",
                 Description="",// biiiiiiiiiiiiiiiiiiiiig
                 Location="",
                 Address="",
                 ImageUrl="AreaImages/xx.jpg",
                 AreaTypeId=2,
           },
        };
        builder.HasData();
    }
}
