using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Egyptos.Infrastructure.Data.Configurations;

public class ItemConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        var items = new List<Item>
        {
            new Item
            {
                Id=1,
                Title="",
                Description="",
                ImageUrl="Items/",
                Date=  new DateOnly(1795,4,1),
                AreaId=101
            },
            new Item
            {
                Id=2,
                Title="",
                Description="",
                ImageUrl="tems/",
                Date=  new DateOnly(1795,4,1),
                AreaId=101
            }

        };
    }
}
