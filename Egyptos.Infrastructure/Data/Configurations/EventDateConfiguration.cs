using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Egyptos.Domain.Entities;

namespace Egyptos.Infrastructure.Data.Configurations;

public class EventDateConfiguration : IEntityTypeConfiguration<EventDate>
{
    public void Configure(EntityTypeBuilder<EventDate> builder)
    {
        var eventDate = new List<EventDate>
        {
            new EventDate
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
                StartDate = new DateTime(2025, 10, 15, 18, 0, 0),
                EndDate = new DateTime(2025, 10, 20, 23, 0, 0),
                StartSubscription = new DateTime(2025, 9, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 10, 10, 23, 59, 0),
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
                StartDate = new DateTime(2025, 10, 25, 18, 0, 0),
                EndDate = new DateTime(2025, 11, 2, 23, 0, 0),
                StartSubscription = new DateTime(2025, 8, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 8, 23, 23, 59, 0),
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
                StartSubscription = new DateTime(2025, 7, 25, 0, 0, 0),
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
                Price = 200,
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
            },
            new EventDate
            {
                Id = 14,
                StartDate = new DateTime(2025, 9, 20, 20, 0, 0),
                EndDate = new DateTime(2025, 9, 24, 23, 59, 59),
                StartSubscription = new DateTime(2025, 9, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 9, 19, 23, 59, 59),
                Description = "A grand parade transferring royal mummies to their new museum with spectacular performances.",
                Location = "Cairo, Egypt",
                Price = 450,
                EventId = 14,
            },
            new EventDate
            {
                Id = 15,
                StartDate = new DateTime(2025, 3, 31, 7, 00, 00),
                EndDate = new DateTime(2025, 4, 2, 12, 00, 00),
                StartSubscription = new DateTime(2025, 3, 17, 8, 00, 00),
                EndSubscription = new DateTime(2025, 3, 30, 8, 00, 00),
                Description = "Eid al-Fitr in Egypt is a major religious and cultural event that celebrates the end of Ramadan, the Islamic holy month of fasting.",
                Location = "Egypt",
                Price = 150,
                EventId = 15,
            },
            new EventDate
            {
                Id = 16,
                StartDate = new DateTime(2025, 2, 2, 10, 00, 00),
                EndDate = new DateTime(2025, 2, 16, 12, 00, 00),
                StartSubscription = new DateTime(2025, 1, 19, 7, 50, 00),
                EndSubscription = new DateTime(2025, 1, 30, 7, 50, 00),
                Description = "​The Aswan International Cultural Festival is an annual event celebrating the rich heritage of Nubian culture through music, dance, and art.",
                Location = "Aswan, Egypt",
                Price = 550,
                EventId = 16,
            },
            new EventDate
            {
                Id = 17,
                StartDate = new DateTime(2025, 4, 12, 7, 00, 00),
                EndDate = new DateTime(2025, 4, 18, 12, 00, 00),
                StartSubscription = new DateTime(2025, 4, 1, 8, 00, 00),
                EndSubscription = new DateTime(2025, 4, 10, 8, 00, 00),
                Description = "​The El Gouna International Squash Open is a premier event on the Professional Squash Association (PSA) World Tour, attracting top players from around the globe.",
                Location = "El Gouna, Egypt",
                Price = 1100,
                EventId = 17,
            },
            new EventDate
            {
                Id = 18,
                StartDate = new DateTime(2025, 11, 15, 10, 00, 00),
                EndDate = new DateTime(2025, 11, 28, 10, 00, 00),
                StartSubscription = new DateTime(2025, 10, 1, 9, 55, 00),
                EndSubscription = new DateTime(2025, 10, 13, 10, 00, 00),
                Description = "The Bibliotheca Alexandrina International Book Fair is an annual cultural event celebrating literature, arts, and intellectual exchange.",
                Location = "Alexandria, Egypt",
                Price = 100,
                EventId = 18,
            },
            new EventDate
            {
                Id = 19,
                StartDate = new DateTime(2025, 10, 15, 9, 00, 00),
                EndDate = new DateTime(2025, 10, 17, 9, 00, 00),
                StartSubscription = new DateTime(2025, 10, 1, 8, 00, 00),
                EndSubscription = new DateTime(2025, 10, 13, 8, 00, 00),
                Description = "​The Siwa Date Festival is an annual celebration held in Siwa Oasis, Egypt, honoring the region's rich tradition of date cultivation. This event showcases the oasis's cultural heritage and agricultural significance.",
                Location = "Siwa, Egypt",
                Price = 200,
                EventId = 19,
            },
            new EventDate
            {
                Id = 20,
                StartDate = new DateTime(2025, 7, 3, 9, 00, 00),
                EndDate = new DateTime(2025, 7, 3, 10, 55, 00),
                StartSubscription = new DateTime(2025, 6, 15, 8, 00, 00),
                EndSubscription = new DateTime(2025, 6, 30, 8, 00, 00),
                Description = "​The Egyptian Museum in Cairo, established in 1902, is renowned for its extensive collection of ancient Egyptian artifacts.",
                Location = "Cairo, Egypt",
                Price = 250,
                EventId = 20,
            },
            new EventDate
            {
                Id = 21,
                StartDate = new DateTime(2026, 1, 6, 12, 00, 00),
                EndDate = new DateTime(2026, 1, 7, 12, 00, 00),
                StartSubscription = new DateTime(2026, 1, 1, 8, 00, 00),
                EndSubscription = new DateTime(2026, 1, 5, 8, 00, 00),
                Description = "Coptic Christmas is a time of profound spiritual reflection and communal celebration, deeply rooted in Egypt's rich Christian heritage, it's celebrated by the Coptic Orthodox Church in Egypt",
                Location = "Egypt",
                Price = 100,
                EventId = 21,
            },
            new EventDate
            {
                Id = 22,
                StartDate = new DateTime(2026, 4, 16, 11, 00, 00),
                EndDate = new DateTime(2026, 4, 26, 10, 00, 00),
                StartSubscription = new DateTime(2026, 4, 1, 8, 00, 00),
                EndSubscription = new DateTime(2026, 4, 13, 8, 00, 00),
                Description = "​The Red Sea region in Egypt is renowned for its vibrant kitesurfing scene, hosting various events and safaris throughout the year.",
                Location = "Red Sea, Egypt",
                Price = 500,
                EventId = 22,
            },
            new EventDate
            {
                Id = 23,
                StartDate = new DateTime(2026, 7, 16, 9, 45, 00),
                EndDate = new DateTime(2026, 7, 21, 10, 55, 00),
                StartSubscription = new DateTime(2026, 7, 3, 8, 00, 00),
                EndSubscription = new DateTime(2026, 7, 12, 8, 00, 00),
                Description = "The Luxor Spring Arts Festival aims to celebrate both contemporary and traditional Egyptian art, providing a platform for local and international artists to showcase their work.​",
                Location = "Luxor, Egypt",
                Price = 450,
                EventId = 23,
            },
            new EventDate
            {
                Id = 24,
                StartDate = new DateTime(2026, 2, 8, 11, 00, 00),
                EndDate = new DateTime(2026, 2, 11, 12, 00, 00),
                StartSubscription = new DateTime(2026, 2, 1, 8, 00, 00),
                EndSubscription = new DateTime(2026, 2, 6, 8, 00, 00),
                Description = "Art Cairo is an annual art fair that showcases contemporary and modern Arab art, providing a platform for artists from Egypt and the broader region to present their work.",
                Location = "Cairo, Egypt",
                Price = 150,
                EventId = 24,
            },
            new EventDate
            {
                Id = 25,
                StartDate = new DateTime(2025, 11, 29, 1, 00, 00),
                EndDate = new DateTime(2025, 11, 29, 10, 50, 00),
                StartSubscription = new DateTime(2025, 11, 20, 8, 00, 00),
                EndSubscription = new DateTime(2025, 11, 25, 12, 00, 00),
                Description = " This conference aims to explore various aspects of Islam and its cultural manifestations.​",
                Location = "Alexandria, Egypt",
                Price = 250,
                EventId = 25,
            },
        };

        builder.HasData(eventDate);
    }
}


public class EventDateImageConfiguration : IEntityTypeConfiguration<EventImage>
{    
    public void Configure(EntityTypeBuilder<EventImage> builder)
    {
        var eventImages = new List<EventImage>
        {
            new EventImage
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
            },new EventImage
            {
                Id = 40,
                ImageUrl="EventImages/40.jpg",
                EventId = 15
            },
            new EventImage
            {
                Id = 41,
                ImageUrl="EventImages/41.jpg",
                EventId = 15
            },
            new EventImage
            {
                Id = 42,
                ImageUrl="EventImages/42.jpg",
                EventId = 15
            },
            new EventImage
            {
                Id = 43,
                ImageUrl="EventImages/43.jpg",
                EventId = 16
            },
            new EventImage
            {
                Id = 44,
                ImageUrl="EventImages/44.jpg",
                EventId = 16
            },
            new EventImage
            {
                Id = 45,
                ImageUrl="EventImages/45.jpg",
                EventId = 16
            },
            new EventImage
            {
                Id = 46,
                ImageUrl="EventImages/46.jpg",
                EventId = 17
            },
            new EventImage
            {
                Id = 47,
                ImageUrl="EventImages/47.jpg",
                EventId = 17
            },
            new EventImage
            {
                Id = 48,
                ImageUrl="EventImages/48.jpg",
                EventId = 17
            },
            new EventImage
            {
                Id = 49,
                ImageUrl="EventImages/49.jpg",
                EventId = 18
            },
            new EventImage
            {
                Id = 50,
                ImageUrl="EventImages/50.jpg",
                EventId = 18
            },
            new EventImage
            {
                Id = 51,
                ImageUrl="EventImages/51.jpg",
                EventId = 18
            },
            new EventImage
            {
                Id = 52,
                ImageUrl="EventImages/52.jpg",
                EventId = 19
            },
            new EventImage
            {
                Id = 53,
                ImageUrl="EventImages/53.jpg",
                EventId = 19
            },
            new EventImage
            {
                Id = 54,
                ImageUrl="EventImages/54.jpg",
                EventId = 19
            },
            new EventImage
            {
                Id = 55,
                ImageUrl="EventImages/55.jpg",
                EventId = 20
            },
            new EventImage
            {
                Id = 56,
                ImageUrl="EventImages/56.jpg",
                EventId = 20
            },
            new EventImage
            {
                Id = 57,
                ImageUrl="EventImages/57.jpg",
                EventId = 20
            },
            new EventImage
            {
                Id = 58,
                ImageUrl="EventImages/58.jpg",
                EventId = 21
            },
            new EventImage
            {
                Id = 59,
                ImageUrl="EventImages/59.jpg",
                EventId = 21
            },
            new EventImage
            {
                Id = 60,
                ImageUrl="EventImages/60.jpg",
                EventId = 21
            },
            new EventImage
            {
                Id = 61,
                ImageUrl="EventImages/61.jpg",
                EventId = 22
            },
            new EventImage
            {
                Id = 62,
                ImageUrl="EventImages/62.jpg",
                EventId = 22
            },
            new EventImage
            {
                Id = 63,
                ImageUrl="EventImages/63.jpg",
                EventId = 22
            },
            new EventImage
            {
                Id = 64,
                ImageUrl="EventImages/64.jpg",
                EventId = 23
            },
            new EventImage
            {
                Id = 65,
                ImageUrl="EventImages/65.jpg",
                EventId = 23
            },
            new EventImage
            {
                Id = 66,
                ImageUrl="EventImages/66.jpg",
                EventId = 23
            },
            new EventImage
            {
                Id = 67,
                ImageUrl="EventImages/67.jpg",
                EventId = 24
            },
            new EventImage
            {
                Id = 68,
                ImageUrl="EventImages/68.jpg",
                EventId = 24
            },
            new EventImage
            {
                Id = 69,
                ImageUrl="EventImages/69.jpg",
                EventId = 24
            },
            new EventImage
            {
                Id = 70,
                ImageUrl="EventImages/70.jpg",
                EventId = 25
            },
            new EventImage
            {
                Id = 71,
                ImageUrl="EventImages/71.jpg",
                EventId = 25
            },
            new EventImage
            {
                Id = 72,
                ImageUrl="EventImages/72.jpg",
                EventId = 25
            },
            new EventImage
            {
                Id = 73,
                ImageUrl="EventImages/73.jpg",
                EventId = 14
            },
            new EventImage
            {
                Id = 74,
                ImageUrl="EventImages/74.jpg",
                EventId = 14
            },
            new EventImage
            {
                Id = 75,
                ImageUrl="EventImages/75.jpg",
                EventId = 14
            }
        };

        builder.HasData(eventImages);
    }
}
