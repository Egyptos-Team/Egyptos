using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Egyptos.Api.Controllers;

public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
{
    public void Configure(EntityTypeBuilder<Hotel> builder)
    {
        var privateTransports = new List<Hotel>
        {
            new Hotel
            {
                 Id = 1,
                 Name = "Hotel1",
                 Location = "LocationUrl",
                 Address = "Address",
                 ImageUrl = "HotelImages/Hotel.jpg",
                 WebSite = "WebSite",
                 Facebook = "Facebook",
                 PhoneNumber = "01010101010",
                 PricePerHour = 1500,

            },
            new Hotel
            { 
                 Id = 2,
                 Name = "Hotel2",
                 Location = "LocationUrl",
                 Address = "Address",
                 ImageUrl = "HotelImages/Hotel.jpg",
                 WebSite = "WebSite",
                 Facebook = "Facebook",
                 PhoneNumber = "01010101010",
                 PricePerHour = 2500,
            }
        };

        //builder.HasData(privateTransports);

    }
}