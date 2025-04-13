using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

class PrivateTransportConfiguration : IEntityTypeConfiguration<PrivateTransport>
{
    public void Configure(EntityTypeBuilder<PrivateTransport> builder)
    {
        var privateTransports = new List<PrivateTransport>
        {
            new PrivateTransport
            {
                Id = 1,
                Name = "Bmw M5",
                PricePerHour = 50.0,
                Description = "Luxury sports sedan with high performance.",
                ImageUrl = "PrivateTransports/Car/bmw-5.jpg",
                Capacity = 4,
                Quantity = 5,
                TransportTypeId = 1
            },
            new PrivateTransport
            {
                Id = 2,
                Name = "Mercedes-Benz S-Class",
                PricePerHour = 60.0,
                Description = "Premium luxury sedan with advanced features.",
                ImageUrl = "PrivateTransports/Car/Mercedes-Benz S-Class.jpeg",
                Capacity = 4,
                Quantity = 5,
                TransportTypeId = 1
            },
            new PrivateTransport
            {
                Id = 3,
                Name = "Audi A8",
                PricePerHour = 55.0,
                Description = "High-end executive car with superior comfort.",
                ImageUrl = "PrivateTransports/Car/Audi A8.jpg",
                Capacity = 4,
                Quantity = 5,
                TransportTypeId = 1
            },
            new PrivateTransport
            {
                Id = 4,
                Name = "Toyota Camry",
                PricePerHour = 30.0,
                Description = "Reliable and comfortable sedan for everyday use.",
                ImageUrl = "PrivateTransports/Car/Toyota Camry.webp",
                Capacity = 4,
                Quantity = 5,
                TransportTypeId = 1
            },
            new PrivateTransport
            {
                Id = 5,
                Name = "Nissan Sunny",
                PricePerHour = 20.0,
                Description = "Affordable compact sedan with great fuel efficiency.",
                ImageUrl = "PrivateTransports/Car/Nissan Sunny.jpg",
                Capacity = 4,
                Quantity = 5,
                TransportTypeId = 1
            },
            new PrivateTransport
            {
                Id = 6,
                Name = "Range Rover Evoque",
                PricePerHour = 70.0,
                Description = "Luxury SUV with off-road capability and elegance.",
                ImageUrl = "PrivateTransports/Car/Range Rover Evoque.jpg",
                Capacity = 4,
                Quantity = 5,
                TransportTypeId = 1
            },
            new PrivateTransport
            {
                Id = 7,
                Name = "Chevrolet Tahoe",
                PricePerHour = 65.0,
                Description = "Spacious full-size SUV perfect for families and groups.",
                ImageUrl = "PrivateTransports/Car/Chevrolet Tahoe.jpg",
                Capacity = 7,
                Quantity = 5,
                TransportTypeId = 1
            },
            new PrivateTransport
            {
                Id = 8,
                Name = "Hyundai Elantra",
                PricePerHour = 25.0,
                Description = "Economical and stylish sedan with modern features.",
                ImageUrl = "PrivateTransports/Car/Hyundai Elantra.jpeg",
                Capacity = 4,
                Quantity = 5,
                TransportTypeId = 1
            },
            new PrivateTransport
            {
                Id = 9,
                Name = "Ford Mustang",
                PricePerHour = 80.0,
                Description = "Classic American muscle car with powerful performance.",
                ImageUrl = "PrivateTransports/Car/Ford Mustang.jpeg",
                Capacity = 4,
                Quantity = 5,
                TransportTypeId = 1
            },
            new PrivateTransport
            {
                Id = 10,
                Name = "Tesla Model S",
                PricePerHour = 90.0,
                Description = "Electric luxury sedan with cutting-edge technology.",
                ImageUrl = "PrivateTransports/Car/Tesla Model S.jpg",
                Capacity = 4,
                Quantity = 5,
                TransportTypeId = 1
            },
            new PrivateTransport
            {
                Id = 11,
                Name = "Kia Sportage",
                PricePerHour = 35.0,
                Description = "Compact SUV with modern features and fuel efficiency.",
                ImageUrl = "PrivateTransports/Car/Kia Sportage.jpg",
                Capacity = 5,
                Quantity = 5,
                TransportTypeId = 1
            },
            new PrivateTransport
            {
                Id = 12,
                Name = "Honda Accord",
                PricePerHour = 40.0,
                Description = "Spacious and comfortable sedan with great reliability.",
                ImageUrl = "PrivateTransports/Car/Honda Accord.jpeg",
                Capacity = 4,
                Quantity = 5,
                TransportTypeId = 1
            },
            new PrivateTransport
            {
                Id = 13,
                Name = "Jeep Wrangler",
                PricePerHour = 75.0,
                Description = "Iconic off-road vehicle for adventure seekers.",
                ImageUrl = "PrivateTransports/Car/Jeep Wrangler.jpeg",
                Capacity = 4,
                Quantity = 5,
                TransportTypeId = 1
            },
            new PrivateTransport
            {
                Id = 14,
                Name = "Volkswagen Passat",
                PricePerHour = 38.0,
                Description = "Reliable and stylish German sedan.",
                ImageUrl = "PrivateTransports/Car/Volkswagen Passat.jpeg",
                Capacity = 4,
                Quantity = 5,
                TransportTypeId = 1
            },
            new PrivateTransport
            {
                Id = 15,
                Name = "Porsche Cayenne",
                PricePerHour = 100.0,
                Description = "Luxury sports SUV with high-end features.",
                ImageUrl = "PrivateTransports/Car/Porsche Cayenne.jpg",
                Capacity = 5,
                Quantity = 5,
                TransportTypeId = 1
            }
            // stop hear 

            ,new PrivateTransport
            {
                Id = 16,
                Name = "Mercedes-Benz Sprinter",
                PricePerHour = 100.0,
                Description = "Luxury minibus with premium comfort.",
                ImageUrl = "PrivateTransports/Bus/Mercedes-Benz Sprinter.jpg",
                Capacity = 15,
                Quantity = 5,
                TransportTypeId = 2
            },
            new PrivateTransport
            {
                Id = 17,
                Name = "Toyota Coaster",
                PricePerHour = 80.0,
                Description = "Comfortable mid-sized bus for group travel.",
                ImageUrl = "PrivateTransports/Bus/Toyota Coaster.jpeg",
                Capacity = 22,
                Quantity = 5,
                TransportTypeId = 2
            },
            new PrivateTransport
            {
                Id = 18,
                Name = "Hyundai County",
                PricePerHour = 75.0,
                Description = "Efficient minibus for short trips.",
                ImageUrl = "PrivateTransports/Bus/Hyundai County.jpeg",
                Capacity = 20,
                Quantity = 5,
                TransportTypeId = 2
            },
            new PrivateTransport
            {
                Id = 19,
                Name = "Mitsubishi Rosa",
                PricePerHour = 85.0,
                Description = "Reliable minibus for tourism and business trips.",
                ImageUrl = "PrivateTransports/Bus/Mitsubishi Rosa.jpg",
                Capacity = 26,
                Quantity = 5,
                TransportTypeId = 2
            },
            new PrivateTransport
            {
                Id = 20,
                Name = "Volvo 9700",
                PricePerHour = 200.0,
                Description = "Luxury long-distance coach with high-end features.",
                ImageUrl = "PrivateTransports/Bus/Volvo 9700.jpg",
                Capacity = 50,
                Quantity = 5,
                TransportTypeId = 2
            },
            new PrivateTransport
            {
                Id = 21,
                Name = "Setra TopClass",
                PricePerHour = 220.0,
                Description = "Premium luxury coach for VIP travel.",
                ImageUrl = "PrivateTransports/Bus/Setra TopClass.jpeg",
                Capacity = 50,
                Quantity = 5,
                TransportTypeId = 2
            },
            new PrivateTransport
            {
                Id = 22,
                Name = "Iveco Daily Minibus",
                PricePerHour = 90.0,
                Description = "Economical minibus for group transport.",
                ImageUrl = "PrivateTransports/Bus/Iveco Daily Minibus.jpeg",
                Capacity = 18,
                Quantity = 5,
                TransportTypeId = 2
            },
            new PrivateTransport
            {
                Id = 23,
                Name = "King Long XMQ6900",
                PricePerHour = 110.0,
                Description = "Spacious tourist bus for comfortable travel.",
                ImageUrl = "PrivateTransports/Bus/King Long XMQ6900.jpg",
                Capacity = 35,
                Quantity = 5,
                TransportTypeId = 2
            },
            new PrivateTransport
            {
                Id = 24,
                Name = "Scania Touring HD",
                PricePerHour = 180.0,
                Description = "Luxury coach with modern amenities.",
                ImageUrl = "PrivateTransports/Bus/Scania Touring HD.jpg",
                Capacity = 55,
                Quantity = 5,
                TransportTypeId = 2
            },
            new PrivateTransport
            {
                Id = 25,
                Name = "MAN Lion’s Coach",
                PricePerHour = 195.0,
                Description = "High-end tourist coach for long-distance trips.",
                ImageUrl = "PrivateTransports/Bus/MAN Lion’s Coach.jpeg",
                Capacity = 50,
                Quantity = 5,
                TransportTypeId = 2
            },
            new PrivateTransport
            {
                Id = 26,
                Name = "Mercedes Tourismo",
                PricePerHour = 210.0,
                Description = "Luxury coach designed for tourism and comfort.",
                ImageUrl = "PrivateTransports/Bus/Mercedes Tourismo.jpeg",
                Capacity = 55,
                Quantity = 5,
                TransportTypeId = 2
            },
            new PrivateTransport
            {
                Id = 27,
                Name = "Neoplan Skyliner",
                PricePerHour = 250.0,
                Description = "Double-decker coach for large group tours.",
                ImageUrl = "PrivateTransports/Bus/Neoplan Skyliner.jpg",
                Capacity = 80,
                Quantity = 5,
                TransportTypeId = 2
            },
            new PrivateTransport
            {
                Id = 28,
                Name = "Yutong ZK6122",
                PricePerHour = 140.0,
                Description = "Reliable and affordable coach for daily transport.",
                ImageUrl = "PrivateTransports/Bus/Yutong ZK6122.jpeg",
                Capacity = 45,
                Quantity = 5,
                TransportTypeId = 2
            },
            new PrivateTransport
            {
                Id = 29,
                Name = "Volvo B11R",
                PricePerHour = 230.0,
                Description = "High-performance luxury coach for premium travel.",
                ImageUrl = "PrivateTransports/Bus/Volvo B11R.jpeg",
                Capacity = 50,
                Quantity = 5,
                TransportTypeId = 2
            },
            new PrivateTransport
            {
                Id = 30,
                Name = "Golden Dragon XML6127",
                PricePerHour = 160.0,
                Description = "Spacious coach with modern amenities.",
                ImageUrl = "PrivateTransports/Bus/Golden Dragon XML6127.jpeg",
                Capacity = 48,
                Quantity = 5,
                TransportTypeId = 2
            }
            //stop her
            ,new PrivateTransport
            {
                Id = 31,
                Name = "Damon Hypersport",
                PricePerHour = 160.0,
                Description = "The scoter is a type of sea duck that lives in cold and temperate regions.",
                ImageUrl = "PrivateTransports/Damon Hypersport.webp",
                Capacity = 2,
                Quantity = 5,
                TransportTypeId = 3
            },
            new PrivateTransport
            {
                Id = 32,
                Name = "Honda CB650R",
                PricePerHour = 250.0,
                Description = "Scooters are easy to handle and convenient for daily transportation.",
                ImageUrl = "PrivateTransports/Honda CB650R.jpg",
                Capacity = 2,
                Quantity = 5,
                TransportTypeId = 3
            },
            new PrivateTransport
            {
                Id = 33,
                Name = "Honda CBR1000RR Fireblade",
                PricePerHour = 200.0,
                Description = "There are three main species of scoter: the black scoter, the surf scoter, and the velvet scoter",
                ImageUrl = "PrivateTransports/Honda CBR1000RR Fireblade.png",
                Capacity = 2,
                Quantity = 5,
                TransportTypeId = 3
            },
            new PrivateTransport
            {
                Id = 34,
                Name = "Kawasaki Ninja",
                PricePerHour = 170.0,
                Description = "Scoters primarily feed on mollusks, crustaceans, and small fish",
                ImageUrl = "PrivateTransports/Kawasaki Ninja.jpeg",
                Capacity = 2,
                Quantity = 5,
                TransportTypeId = 3
            },

            new PrivateTransport
            {
                Id = 35,
                Name = "KTM Duke 1290 R",
                PricePerHour = 130.0,
                Description = "They have dark-colored feathers, with males usually appearing blacker than females.",
                ImageUrl = "PrivateTransports/KTM Duke 1290 R.jpg",
                Capacity = 2,
                Quantity = 5,
                TransportTypeId = 3
            },
            new PrivateTransport
            {
                Id = 36,
                Name = "Lightning LS-218",
                PricePerHour = 110.0,
                Description = "Scoters prefer coastal waters and large water bodies like lakes and rivers.",
                ImageUrl = "PrivateTransports/Lightning LS-218.jpg",
                Capacity = 2,
                Quantity = 5,
                TransportTypeId = 3
            },
            new PrivateTransport
            {
                Id = 37,
                Name = "my22-tiger-1200-gt-explorer",
                PricePerHour = 120.0,
                Description = "Electric scooters are commonly used for short-distance travel in cities.",
                ImageUrl = "PrivateTransports/my22-tiger-1200-gt-explorer-lucerne-blue-rhs-1080.png",
                Capacity = 2,
                Quantity = 5,
                TransportTypeId = 3
            },
            new PrivateTransport
            {
                Id = 38,
                Name = "Suzuki GSX R1000",
                PricePerHour = 150.0,
                Description = "Kick scooters are popular among children and some commuters.",
                ImageUrl = "PrivateTransports/Suzuki GSX R1000.jpeg",
                Capacity = 2,
                Quantity = 5,
                TransportTypeId = 3
            },
            new PrivateTransport
            {
                Id = 39,
                Name = "Yamaha YZF",
                PricePerHour = 100.0,
                Description = "Scooters are easy to handle and convenient for daily transportation.",
                ImageUrl = "PrivateTransports/Yamaha YZF.jpg",
                Capacity = 2,
                Quantity = 5,
                TransportTypeId = 3
            }, new PrivateTransport
             {
                 Id = 40,
                 Name = "Road Bike",
                 PricePerHour = 70.0,
                 Description = "A sleek and lightweight bicycle built for speed and long-distance rides on paved roads",
                 ImageUrl = "PrivateTransports/Bike/Road_Bike.jpg",
                 Capacity = 1,
                 Quantity = 11,
                 TransportTypeId = 4
             },new PrivateTransport
             {
                 Id = 41,
                 Name = "Mountain Bike",
                 PricePerHour = 50.0,
                 Description = "A rugged bike built for off-road trails",
                 ImageUrl = "PrivateTransports/Bike/Mountain_Bike.jpg",
                 Capacity = 1,
                 Quantity = 11,
                 TransportTypeId = 4
             },new PrivateTransport
             {
                 Id = 42,
                 Name = "City Commuter Bike",
                 PricePerHour = 40.0,
                 Description = "Designed for daily urban commuting",
                 ImageUrl = "PrivateTransports/Bike/City_Commuter_Bike.jpg",
                 Capacity = 1,
                 Quantity = 11,
                 TransportTypeId = 4
             },new PrivateTransport
             {
                 Id = 43,
                 Name = "Cruiser Bike",
                 PricePerHour = 60.0,
                 Description = "A stylish and relaxed bicycle for leisurely rides",
                 ImageUrl = "PrivateTransports/Bike/Cruiser_Bike.jpg",
                 Capacity = 1,
                 Quantity = 11,
                 TransportTypeId = 4
             },new PrivateTransport
             {
                 Id = 44,
                 Name = "Electric Bike",
                 PricePerHour = 140.0,
                 Description = "A modern bicycle with an electric motor and battery for pedal-assist riding, ideal for long distances and commuting with ease and less effort.",
                 ImageUrl = "PrivateTransports/Bike/Electric_Bike.jpg",
                 Capacity = 1,
                 Quantity = 11,
                 TransportTypeId = 4
             },new PrivateTransport
             {
                 Id = 45,
                 Name = "Trek Domane SL 6",
                 PricePerHour = 150.0,
                 Description = "Endurance-focused road bike with IsoSpeed technology for smoother rides over long distances.",
                 ImageUrl = "PrivateTransports/Bike/Trek_Domane_SL_6.jpg",
                 Capacity = 1,
                 Quantity = 11,
                 TransportTypeId = 4
             },new PrivateTransport
             {
                 Id = 46,
                 Name = "Specialized Allez Sprint Comp",
                 PricePerHour = 170.0,
                 Description = "A performance alloy race bike with aggressive geometry, ideal for speed and competitive cycling.",
                 ImageUrl = "PrivateTransports/Bike/Specialized.jpg",
                 Capacity = 1,
                 Quantity = 11,
                 TransportTypeId = 4
             },new PrivateTransport
             {
                 Id = 47,
                 Name = "Cannondale Trail 5",
                 PricePerHour = 120.0,
                 Description = "A versatile hardtail mountain bike with front suspension, perfect for beginner to intermediate trail",
                 ImageUrl = "PrivateTransports/Bike/Cannondale.jpg",
                 Capacity = 1,
                 Quantity = 11,
                 TransportTypeId = 4
             },new PrivateTransport
             {
                 Id = 48,
                 Name = "Giant Escape 3",
                 PricePerHour = 130.0,
                 Description = "A lightweight hybrid city bike designed for efficient daily commuting and fitness rides.",
                 ImageUrl = "PrivateTransports/Bike/Giant.jpg",
                 Capacity = 1,
                 Quantity = 11,
                 TransportTypeId = 4
             },new PrivateTransport
             {
                 Id = 49,
                 Name = "Rad Power Bikes RadCity 5 Plus",
                 PricePerHour = 150.0,
                 Description = "A commuter-focused e-bike with a powerful motor, integrated lights, and a rear rack.",
                 ImageUrl = "PrivateTransports/Bike/Rad_Power.jpg",
                 Capacity = 1,
                 Quantity = 11,
                 TransportTypeId = 4
             }
        };

        builder.HasData(privateTransports);

    }
}
