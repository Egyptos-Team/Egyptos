using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class AreaImagesConfiguration : IEntityTypeConfiguration<AreaImage>
{
    public void Configure(EntityTypeBuilder<AreaImage> builder)
    {
        var areaImages = new List<AreaImage>
        {
            new AreaImage
            {
                Id=1,
                Description="",
                ImageUrl="AreaImages/xx.jpg",
                AreaId=31
            },
            new AreaImage
            {
                Id=2,
                Description="",
                ImageUrl="AreaImages/xx.jpg",
                AreaId=31
            },
        };
        builder.HasData();
    }
}
