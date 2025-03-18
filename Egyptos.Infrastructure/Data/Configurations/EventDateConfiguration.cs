using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Egyptos.Domain.Entities;

namespace Egyptos.Infrastructure.Data.Configurations;

public class EventDateConfiguration : IEntityTypeConfiguration<EventDate>
{
    public void Configure(EntityTypeBuilder<EventDate> builder)
    {
        var eventDate5 = new List<EventDate>
        {
           /* new EventDate
            {
                Id = 1,
                StartDate = new DateTime(2025, 7, 10, 10, 00, 00),
                EndDate = new DateTime(2025, 7, 10, 23, 59, 00),
                StartSubscription = new DateTime(2025, 10, 1, 00, 00, 00),
                EndSubscription = new DateTime(2025, 10, 9, 23, 59, 00),
                Description = "A festival celebrating Ismailia's famous mangoes with exhibitions and entertainment.",
                Location = "Ismailia, Egypt",
                Price = 100,
                EventId = 1,
            },
            new EventDate
            {
                Id = 2,
                StartDate = new DateTime(2025, 4, 15, 18, 0, 0),
                EndDate = new DateTime(2025, 4, 20, 23, 0, 0),
                StartSubscription = new DateTime(2025, 3, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 4, 10, 23, 59, 0),
                Description = "A festival showcasing short films from Egypt and beyond, attracting filmmakers and critics.",
                Location = "Alexandria, Egypt",
                Price = 150,
                EventId = 2,
            },
            new EventDate
            {
                Id = 3,
                StartDate = new DateTime(2025, 3, 8, 17, 0, 0),
                EndDate = new DateTime(2025, 3, 15, 22, 0, 0),
                StartSubscription = new DateTime(2025, 2, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 3, 5, 23, 59, 0),
                Description = "A festival dedicated to women in theatre, featuring performances and discussions.",
                Location = "Cairo, Egypt",
                Price = 120,
                EventId = 3,
            },

            new EventDate
            {
                Id = 4,
                StartDate = new DateTime(2025, 2, 21, 6, 0, 0),
                EndDate = new DateTime(2025, 2, 21, 8, 0, 0),
                StartSubscription = new DateTime(2025, 1, 10, 0, 0, 0),
                EndSubscription = new DateTime(2025, 2, 18, 23, 59, 0),
                Description = "An astronomical event where the sun aligns with the temple’s axis, showcasing ancient Egyptian ingenuity.",
                Location = "Karnak Temple, Luxor, Egypt",
                Price = 250,
                EventId = 4,
            },
            new EventDate
            {
                Id = 5,
                StartDate = new DateTime(2025, 11, 10, 19, 0, 0),
                EndDate = new DateTime(2025, 11, 20, 23, 59, 0),
                StartSubscription = new DateTime(2025, 9, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 11, 5, 23, 59, 0),
                Description = "One of the Arab world's most prestigious film festivals, drawing filmmakers and critics.",
                Location = "Cairo, Egypt",
                Price = 200,
                EventId = 5,
            },
            new EventDate
            {
                Id = 6,
                StartDate = new DateTime(2025, 5, 1, 20, 0, 0),
                EndDate = new DateTime(2025, 5, 1, 21, 0, 0),
                StartSubscription = new DateTime(2025, 4, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 4, 30, 23, 59, 0),
                Description = "A spectacular show narrating Egypt’s history using sound and light projections on the pyramids.",
                Location = "Giza Pyramids, Egypt",
                Price = 180,
                EventId = 6,
            },
            new EventDate
            {
                Id = 7,
                StartDate = new DateTime(2025, 3, 25, 18, 0, 0),
                EndDate = new DateTime(2025, 4, 2, 23, 0, 0),
                StartSubscription = new DateTime(2025, 3, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 3, 23, 23, 59, 0),
                Description = "A festival celebrating Ramadan with beautiful lantern displays and cultural performances.",
                Location = "Cairo, Egypt",
                Price = 80,
                EventId = 7,
            },
            new EventDate
            {
                Id = 8,
                StartDate = new DateTime(2025, 8, 15, 12, 0, 0),
                EndDate = new DateTime(2025, 8, 20, 23, 0, 0),
                StartSubscription = new DateTime(2025, 7, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 8, 10, 23, 59, 0),
                Description = "A vibrant summer festival with music, dance, and water activities along the Red Sea coast.",
                Location = "Hurghada, Egypt",
                Price = 150,
                EventId = 8,
            },
            new EventDate
            {
                Id = 9,
                StartDate = new DateTime(2025, 12, 5, 17, 0, 0),
                EndDate = new DateTime(2025, 12, 10, 23, 0, 0),
                StartSubscription = new DateTime(2025, 10, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 12, 1, 23, 59, 0),
                Description = "A theatre festival featuring international performances, workshops, and panel discussions.",
                Location = "Sharm El Sheikh, Egypt",
                Price = 170,
                EventId = 9,
            },
            new EventDate
            {
                Id = 10,
                StartDate = new DateTime(2025, 3, 15, 10, 0, 0),
                EndDate = new DateTime(2025, 3, 15, 18, 0, 0),
                StartSubscription = new DateTime(2025, 2, 15, 0, 0, 0),
                EndSubscription = new DateTime(2025, 3, 10, 23, 59, 59),
                Description = "An exhibition showcasing the treasures of King Tutankhamun.",
                Location = "Cairo Museum",
                Price = 300,
                EventId = 10,
            },

            new EventDate
            {
                Id = 11,
                StartDate = new DateTime(2025, 9, 26, 18, 0, 0),
                EndDate = new DateTime(2025, 9, 26, 23, 0, 0),
                StartSubscription = new DateTime(2025, 8, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 9, 20, 23, 59, 59),
                Description = "Religious festival celebrating Prophet Muhammad’s birth.",
                Location = "Al Azhar Mosque",
                Price = 0,
                EventId = 11,
            },
            new EventDate
            {
                Id = 12,
                StartDate = new DateTime(2025, 6, 10, 17, 0, 0),
                EndDate = new DateTime(2025, 6, 10, 23, 0, 0),
                StartSubscription = new DateTime(2025, 5, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 6, 5, 23, 59, 59),
                Description = "A cultural festival celebrating Egyptian heritage.",
                Location = "Giza Plateau",
                Price = 150,
                EventId = 12,
            },
            new EventDate
            {
                Id = 13,
                StartDate = new DateTime(2025, 10, 20, 19, 0, 0),
                EndDate = new DateTime(2025, 10, 28, 23, 59, 59),
                StartSubscription = new DateTime(2025, 9, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 10, 15, 23, 59, 59),
                Description = "A prestigious international film festival held in El Gouna.",
                Location = "El Gouna, Red Sea",
                Price = 500,
                EventId = 13,
            }*/
        };

        //builder.HasData(eventDate5);
    }
}


public class EventDateImageConfiguration : IEntityTypeConfiguration<EventImage>
{    
    public void Configure(EntityTypeBuilder<EventImage> builder)
    {
        var eventImages = new List<EventImage>
        {
            /*new EventImage
            {
                Id = 1,
                ImageUrl="EventImages/Ismailia/1.webp",
                EventId = 1
            },
            new EventImage
            {
                Id = 2,
                ImageUrl="EventImages/Ismailia/2.webp",
                EventId = 1
            },
            new EventImage
            {
                Id = 3,
                ImageUrl="EventImages/Ismailia/3.webp",
                EventId = 1
            },

            new EventImage
            {
                Id = 4,
                ImageUrl="EventImages/Alexandria/1.webp",
                EventId = 2
            },
            new EventImage
            {
                Id = 5,
                ImageUrl="EventImages/Alexandria/2.webp",
                EventId = 2
            },
            new EventImage
            {
                Id = 6,
                ImageUrl="EventImages/Alexandria/3.webp",
                EventId = 2
            },

            new EventImage
            {
                Id = 7,
                ImageUrl="EventImages/Cairo/1.webp",
                EventId = 3
            },
            new EventImage
            {
                Id = 8,
                ImageUrl="EventImages/Cairo/2.webp",
                EventId = 3
            },
            new EventImage
            {
                Id = 9,
                ImageUrl="EventImages/Cairo/3.webp",
                EventId = 3
            },

            new EventImage
            {
                Id = 10,
                ImageUrl="EventImages/Karnak Temple, Luxor, Egypt/1.webp",
                EventId = 4
            },
            new EventImage
            {
                Id = 11,
                ImageUrl="EventImages/Karnak Temple, Luxor, Egypt/2.webp",
                EventId = 4
            },
            new EventImage
            {
                Id = 12,
                ImageUrl="EventImages/Karnak Temple, Luxor, Egypt/3.webp",
                EventId = 4
            },

            new EventImage
            {
                Id = 13,
                ImageUrl="EventImages/Cairo,Egypt/1.webp",
                EventId = 5
            },
            new EventImage
            {
                Id = 14,
                ImageUrl="EventImages/Cairo,Egypt/2.webp",
                EventId = 5
            },
            new EventImage
            {
                Id = 15,
                ImageUrl="EventImages/Cairo,Egypt/3.webp",
                EventId = 5
            },

            new EventImage
            {
                Id = 16,
                ImageUrl="EventImages/Giza Pyramids, Egypt/1.webp",
                EventId = 6
            },
            new EventImage
            {
                Id = 17,
                ImageUrl="EventImages/Giza Pyramids, Egypt/2.webp",
                EventId = 6
            },
            new EventImage
            {
                Id = 18,
                ImageUrl="EventImages/Giza Pyramids, Egypt/3.webp",
                EventId = 6
            },

            new EventImage
            {
                Id = 19,
                ImageUrl="EventImages/Cairo, Egypt2/1.webp",
                EventId = 7
            },
            new EventImage
            {
                Id = 20,
                ImageUrl="EventImages/Cairo, Egypt2/2.webp",
                EventId = 7
            },
            new EventImage
            {
                Id = 21,
                ImageUrl="EventImages/Cairo, Egypt2/3.webp",
                EventId = 7
            },

            new EventImage
            {
                Id = 22,
                ImageUrl="EventImages/Hurghada, Egypt/1.webp",
                EventId = 8
            },
            new EventImage
            {
                Id = 23,
                ImageUrl="EventImages/Hurghada, Egypt/2.webp",
                EventId = 8
            },
            new EventImage
            {
                Id = 24,
                ImageUrl="EventImages/Hurghada, Egypt/3.webp",
                EventId = 8
            },

            new EventImage
            {
                Id = 25,
                ImageUrl="EventImages/Sharm El Sheikh, Egypt/1.webp",
                EventId = 9
            },
            new EventImage
            {
                Id = 26,
                ImageUrl="EventImages/Sharm El Sheikh, Egypt/2.webp",
                EventId = 9
            },
            new EventImage
            {
                Id = 27,
                ImageUrl="EventImages/Sharm El Sheikh, Egypt/3.webp",
                EventId = 9
            },

            new EventImage
            {
                Id = 28,
                ImageUrl="EventImages/Cairo Museum/1.webp",
                EventId = 10
            },
            new EventImage
            {
                Id = 29,
                ImageUrl="EventImages/Cairo Museum/2.webp",
                EventId = 10
            },
            new EventImage
            {
                Id = 30,
                ImageUrl="EventImages/Cairo Museum/3.webp",
                EventId = 10
            },

            new EventImage
            {
                Id = 31,
                ImageUrl="EventImages/Al Azhar Mosque/1.webp",
                EventId = 11
            },
            new EventImage
            {
                Id = 32,
                ImageUrl="EventImages/Al Azhar Mosque/2.webp",
                EventId = 11
            },
            new EventImage
            {
                Id = 33,
                ImageUrl="EventImages/Al Azhar Mosque/3.webp",
                EventId = 11
            },

            new EventImage
            {
                Id = 34,
                ImageUrl="EventImages/Giza Plateau/1.webp",
                EventId = 12
            },
            new EventImage
            {
                Id = 35,
                ImageUrl="EventImages/Giza Plateau/2.webp",
                EventId = 12
            },
            new EventImage
            {
                Id = 36,
                ImageUrl="EventImages/Giza Plateau/3.webp",
                EventId = 12
            },

            new EventImage
            {
                Id = 37,
                ImageUrl="EventImages/El Gouna, Red Sea/1.webp",
                EventId = 13
            },
            new EventImage
            {
                Id = 38,
                ImageUrl="EventImages/El Gouna, Red Sea/2.webp",
                EventId = 13
            },
            new EventImage
            {
                Id = 39,
                ImageUrl="EventImages/El Gouna, Red Sea/3.webp",
                EventId = 13
            }*/

        };

        //builder.HasData();
    }
}
