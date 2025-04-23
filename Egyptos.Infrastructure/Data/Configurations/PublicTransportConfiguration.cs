using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class PublicTransportConfiguration : IEntityTypeConfiguration<PublicTransport>
{
    public void Configure(EntityTypeBuilder<PublicTransport> builder)
    {
        builder.Property(p => p.SerialNumber)
            .ValueGeneratedNever();

        builder.HasIndex(p => p.SerialNumber)
            .IsUnique();
        
        var PublicTransport = new List<PublicTransport>
        {
            new PublicTransport
            {
                Id = 1,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 1001,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 2,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 1002,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 3,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 1003,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 4,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 1004,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 5,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 1005,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 6,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 1006,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 7,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 1007,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 8,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 1008,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 9,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 1009,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 10,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 1010,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 11,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 1011,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 12,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 1012,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 13,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 1013,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 14,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 1014,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 15,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 1015,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 16,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 1016,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 17,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 1017,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 18,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 1018,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 19,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 1019,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 20,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 1020,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 21,
                Name = "Minibus",
                Capacity = 18,
                ImageUrl = "bus.svg",
                SerialNumber = 2001,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 22,
                Name = "Bus",
                Capacity = 35,
                ImageUrl = "bus.svg",
                SerialNumber = 2002,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 23,
                Name = "Minibus",
                Capacity = 18,
                ImageUrl = "bus.svg",
                SerialNumber = 2003,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 24,
                Name = "Bus",
                Capacity = 35,
                ImageUrl = "bus.svg",
                SerialNumber = 2004,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 25,
                Name = "Minibus",
                Capacity = 18,
                ImageUrl = "bus.svg",
                SerialNumber = 2005,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 26,
                Name = "Bus",
                Capacity = 35,
                ImageUrl = "bus.svg",
                SerialNumber = 2006,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 27,
                Name = "Minibus",
                Capacity = 18,
                ImageUrl = "bus.svg",
                SerialNumber = 2007,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 28,
                Name = "Bus",
                Capacity = 35,
                ImageUrl = "bus.svg",
                SerialNumber = 2008,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 29,
                Name = "Minibus",
                Capacity = 18,
                ImageUrl = "bus.svg",
                SerialNumber = 2009,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 30,
                Name = "Bus",
                Capacity = 35,
                ImageUrl = "bus.svg",
                SerialNumber = 2010,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 31,
                Name = "Minibus",
                Capacity = 18,
                ImageUrl = "bus.svg",
                SerialNumber = 2011,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 32,
                Name = "Bus",
                Capacity = 35,
                ImageUrl = "bus.svg",
                SerialNumber = 2012,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 33,
                Name = "Minibus",
                Capacity = 18,
                ImageUrl = "bus.svg",
                SerialNumber = 2013,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 34,
                Name = "Bus",
                Capacity = 35,
                ImageUrl = "bus.svg",
                SerialNumber = 2014,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 35,
                Name = "Minibus",
                Capacity = 18,
                ImageUrl = "bus.svg",
                SerialNumber = 2015,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 36,
                Name = "Bus",
                Capacity = 35,
                ImageUrl = "bus.svg",
                SerialNumber = 2016,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 37,
                Name = "Minibus",
                Capacity = 18,
                ImageUrl = "bus.svg",
                SerialNumber = 2017,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 38,
                Name = "Bus",
                Capacity = 35,
                ImageUrl = "bus.svg",
                SerialNumber = 2018,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 39,
                Name = "Minibus",
                Capacity = 18,
                ImageUrl = "bus.svg",
                SerialNumber = 2019,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 40,
                Name = "Bus",
                Capacity = 35,
                ImageUrl = "bus.svg",
                SerialNumber = 2020,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 41,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 1041,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 42,
                Name = "Bus",
                Capacity = 32,
                ImageUrl = "bus.svg",
                SerialNumber = 1042,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 43,
                Name = "Bus",
                Capacity = 28,
                ImageUrl = "bus.svg",
                SerialNumber = 1043,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 44,
                Name = "Bus",
                Capacity = 35,
                ImageUrl = "bus.svg",
                SerialNumber = 1044,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 45,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 1045,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 46,
                Name = "Bus",
                Capacity = 33,
                ImageUrl = "bus.svg",
                SerialNumber = 1046,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 47,
                Name = "Bus",
                Capacity = 31,
                ImageUrl = "bus.svg",
                SerialNumber = 1047,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 48,
                Name = "Bus",
                Capacity = 29,
                ImageUrl = "bus.svg",
                SerialNumber = 1048,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 49,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 1049,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 50,
                Name = "Bus",
                Capacity = 34,
                ImageUrl = "bus.svg",
                SerialNumber = 1050,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 51,
                Name = "Luxury Yacht",
                Capacity = 10,
                ImageUrl = "boat.svg",
                SerialNumber = 1051,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 52,
                Name = "Sailing Boat",
                Capacity = 8,
                ImageUrl = "boat.svg",
                SerialNumber = 1052,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 53,
                Name = "Speed Boat",
                Capacity = 6,
                ImageUrl = "boat.svg",
                SerialNumber = 1053,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 54,
                Name = "Fishing Boat",
                Capacity = 5,
                ImageUrl = "boat.svg",
                SerialNumber = 1054,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 55,
                Name = "Motor Yacht",
                Capacity = 9,
                ImageUrl = "boat.svg",
                SerialNumber = 1055,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 56,
                Name = "House Boat",
                Capacity = 12,
                ImageUrl = "boat.svg",
                SerialNumber = 1056,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 57,
                Name = "Pontoon Boat",
                Capacity = 10,
                ImageUrl = "boat.svg",
                SerialNumber = 1057,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 58,
                Name = "Jet Boat",
                Capacity = 4,
                ImageUrl = "boat.svg",
                SerialNumber = 1058,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 59,
                Name = "Catamaran",
                Capacity = 14,
                ImageUrl = "boat.svg",
                SerialNumber = 1059,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 60,
                Name = "Cruiser Boat",
                Capacity = 11,
                ImageUrl = "boat.svg",
                SerialNumber = 1060,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 61,
                Name = "Jeep Wrangler",
                Capacity = 5,
                ImageUrl = "jeep.svg",
                SerialNumber = 1061,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 62,
                Name = "Toyota Land Cruiser",
                Capacity = 7,
                ImageUrl = "jeep.svg",
                SerialNumber = 1062,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 63,
                Name = "Nissan Patrol",
                Capacity = 7,
                ImageUrl = "jeep.svg",
                SerialNumber = 1063,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 64,
                Name = "Range Rover Defender",
                Capacity = 5,
                ImageUrl = "jeep.svg",
                SerialNumber = 1064,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 65,
                Name = "Jeep Grand Cherokee",
                Capacity = 5,
                ImageUrl = "jeep.svg",
                SerialNumber = 1065,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 66,
                Name = "Ford Bronco",
                Capacity = 5,
                ImageUrl = "jeep.svg",
                SerialNumber = 1066,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 67,
                Name = "Chevrolet Tahoe",
                Capacity = 8,
                ImageUrl = "jeep.svg",
                SerialNumber = 1067,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 68,
                Name = "Mercedes G-Class",
                Capacity = 5,
                ImageUrl = "jeep.svg",
                SerialNumber = 1068,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 69,
                Name = "Toyota Prado",
                Capacity = 7,
                ImageUrl = "jeep.svg",
                SerialNumber = 1069,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 70,
                Name = "Mitsubishi Pajero",
                Capacity = 7,
                ImageUrl = "jeep.svg",
                SerialNumber = 1070,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 71,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 10071,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 72,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 10072,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 73,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 10073,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 74,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 10074,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 75,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 10075,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 76,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 10076,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 77,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 10077,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 78,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 10078,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 81,
                Name = "Jeep Wrangler",
                Capacity = 5,
                ImageUrl = "jeep.svg",
                SerialNumber = 10081,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 82,
                Name = "Toyota Land Cruiser",
                Capacity = 7,
                ImageUrl = "jeep.svg",
                SerialNumber = 10082,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 83,
                Name = "Nissan Patrol",
                Capacity = 7,
                ImageUrl = "jeep.svg",
                SerialNumber = 10083,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 84,
                Name = "Range Rover Defender",
                Capacity = 5,
                ImageUrl = "jeep.svg",
                SerialNumber = 10084,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 85,
                Name = "Jeep Grand Cherokee",
                Capacity = 5,
                ImageUrl = "jeep.svg",
                SerialNumber = 10085,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 86,
                Name = "Ford Bronco",
                Capacity = 5,
                ImageUrl = "jeep.svg",
                SerialNumber = 10086,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 87,
                Name = "Chevrolet Tahoe",
                Capacity = 8,
                ImageUrl = "jeep.svg",
                SerialNumber = 10087,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 88,
                Name = "Mercedes G-Class",
                Capacity = 5,
                ImageUrl = "jeep.svg",
                SerialNumber = 10088,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 89,
                Name = "Toyota Prado",
                Capacity = 7,
                ImageUrl = "jeep.svg",
                SerialNumber = 10089,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 90,
                Name = "Mitsubishi Pajero",
                Capacity = 7,
                ImageUrl = "jeep.svg",
                SerialNumber = 10090,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 91,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 4623,
                IsAvailable = 1
            },
            new PublicTransport
            {
                Id = 92,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 5938,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 93,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 7757,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 94,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 6162,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 95,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 8114,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 96,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 9631,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 97,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 4461,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 98,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 4216,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 99,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 8283,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 100,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 3018,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 101,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 3572,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 102,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 7150,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 103,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 4507,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 104,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 7831,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 105,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 6202,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 106,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 8287,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 107,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 9618,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 108,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 9306,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 109,
                Name = "Bus",
                Capacity = 30,
                ImageUrl = "bus.svg",
                SerialNumber = 9220,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 110,
                Name = "Minibus",
                Capacity = 15,
                ImageUrl = "bus.svg",
                SerialNumber = 4937,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 111,
                Name = "Minibus",
                Capacity = 18,
                ImageUrl = "bus.svg",
                SerialNumber = 7651,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 112,
                Name = "Bus",
                Capacity = 35,
                ImageUrl = "bus.svg",
                SerialNumber = 8165,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 113,
                Name = "Minibus",
                Capacity = 18,
                ImageUrl = "bus.svg",
                SerialNumber = 7413,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 114,
                Name = "Bus",
                Capacity = 35,
                ImageUrl = "bus.svg",
                SerialNumber = 6657,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 115,
                Name = "Minibus",
                Capacity = 18,
                ImageUrl = "bus.svg",
                SerialNumber = 8346,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 116,
                Name = "Bus",
                Capacity = 35,
                ImageUrl = "bus.svg",
                SerialNumber = 6689,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 117,
                Name = "Minibus",
                Capacity = 18,
                ImageUrl = "bus.svg",
                SerialNumber = 4791,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 118,
                Name = "Bus",
                Capacity = 35,
                ImageUrl = "bus.svg",
                SerialNumber = 4279,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 119,
                Name = "Minibus",
                Capacity = 18,
                ImageUrl = "bus.svg",
                SerialNumber = 8850,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 120,
                Name = "Bus",
                Capacity = 35,
                ImageUrl = "bus.svg",
                SerialNumber = 4491,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 121,
                Name = "Minibus",
                Capacity = 18,
                ImageUrl = "bus.svg",
                SerialNumber = 6930,
                IsAvailable = 1
            },

            new PublicTransport
            {
                Id = 122,
                Name = "Bus",
                Capacity = 35,
                ImageUrl = "bus.svg",
                SerialNumber = 8701,
                IsAvailable = 1
            },

        };
        builder.HasData(PublicTransport);
    }
}
