using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Egyptos.Infrastructure.Data.Configurations;

public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        var events = new List<Event>
        {
            new Event
            {
                Id = 1,
                Name = "Ismailia Mango Festival",
                Description = "A festival celebrating Ismailia's famous mangoes with exhibitions and entertainment.",
                EventTypeId = 4
            },
            new Event
            {
                Id = 2,
                Name = "Alexandria Short Film Festival",
                Description = "A festival showcasing short films from Egypt and beyond, attracting filmmakers and critics.",
                EventTypeId = 5
            },
            new Event
            {
                Id = 3,
                Name = "International Women Theatre Festival",
                Description = "A festival dedicated to women in theatre, featuring performances and discussions.",
                EventTypeId = 5
            },
            new Event
            {
                Id = 4,
                Name = "The Solar Alignment on the Karnak Temple",
                Description = "An astronomical event where the sun aligns with the temple’s axis, showcasing ancient Egyptian ingenuity.",
                EventTypeId = 2
            },
            new Event
            {
                Id = 5,
                Name = "Cairo International Film Festival",
                Description = "One of the Arab world's most prestigious film festivals, drawing filmmakers and critics.",
                EventTypeId = 1
            },
            new Event
            {
                Id = 6,
                Name = "Giza Pyramids Sound and Light Show",
                Description = "A spectacular show narrating Egypt’s history using sound and light projections on the pyramids.",
                EventTypeId = 2
            },
            new Event
            {
                Id = 7,
                Name = "Ramadan Lantern Festival",
                Description = "A festival celebrating Ramadan with beautiful lantern displays and cultural performances.",
                EventTypeId = 3
            },
            new Event
            {
                Id = 8,
                Name = "Hurghada Summer Festival",
                Description = "A vibrant summer festival with music, dance, and water activities along the Red Sea coast.",
                EventTypeId = 4
            },
            new Event
            {
                Id = 9,
                Name = "Sharm El Sheikh International Theatre Festival",
                Description = "A theatre festival featuring international performances, workshops, and panel discussions.",
                EventTypeId = 1
            },
            new Event
            {
                Id = 10,
                Name = "Tutankhamun Exhibition",
                Description = "An exhibition displaying King Tutankhamun’s treasures, offering insights into his life and reign.",
                EventTypeId = 2
            },
            new Event
            {
                Id = 11,
                Name = "Mawlid Al-Nabi Celebrations",
                Description = "A religious festival celebrating Prophet Muhammad’s birth with prayers and parades.",
                EventTypeId = 3
            },
            new Event
            {
                Id = 12,
                Name = "Sphinx Festival",
                Description = "A cultural festival celebrating Egyptian heritage with traditional music and storytelling.",
                EventTypeId = 4
            },
            new Event
            {
                Id = 13,
                Name = "El Gouna Film Festival",
                Description = "An international film festival held in El Gouna, featuring high-quality films and industry panels.",
                EventTypeId = 1
            },
            new Event
            {
                Id = 14,
                Name = "Pharaohs' Golden Parade",
                Description = "A grand parade transferring royal mummies to their new museum with spectacular performances.",
                EventTypeId = 2
            },
            new Event
            {
                Id = 15,
                Name = "Eid Al-Fitr Festivities",
                Description = "Nationwide celebrations marking the end of Ramadan with special prayers and cultural events.",
                EventTypeId = 3
            },
            new Event
            {
                Id = 16,
                Name = "Aswan Nubian Festival",
                Description = "A festival celebrating Nubian traditions with music, dance, and traditional crafts.",
                EventTypeId = 4
            },
            new Event
            {
                Id = 17,
                Name = "Gouna Squash Open",
                Description = "An international squash tournament held in El Gouna, featuring top-ranked players.",
                EventTypeId = 1
            },
            new Event
            {
                Id = 18,
                Name = "Alexandria Book Fair",
                Description = "A major book fair attracting authors and publishers for literary discussions and signings.",
                EventTypeId = 5
            },
            new Event
            {
                Id = 19,
                Name = "Siwa Date Festival",
                Description = "A festival celebrating Siwa Oasis’ famous dates, featuring local crafts and traditions.",
                EventTypeId = 4
            },
            new Event
            {
                Id = 20,
                Name = "Egyptian Museum Anniversary Exhibition",
                Description = "A special exhibition marking the anniversary of the Egyptian Museum with rare artifacts on display.",
                EventTypeId = 2
            },
            new Event
            {
                Id = 21,
                Name = "Coptic Christmas Celebrations",
                Description = "A religious celebration of Coptic Christmas, featuring prayers, feasts, and community gatherings.",
                EventTypeId = 3
            },
            new Event
            {
                Id = 22,
                Name = "Red Sea Kite Surfing Championship",
                Description = "An international kite surfing competition held on Egypt’s Red Sea coast, attracting top athletes.",
                EventTypeId = 1
            },
            new Event
            {
                Id = 23,
                Name = "Luxor Art Exhibition",
                Description = "An annual exhibition displaying works from Egypt's top artists in the historic city of Luxor.",
                EventTypeId = 5
            },
            new Event
            {
                Id = 24,
                Name = "Cairo Street Art Festival",
                Description = "A festival celebrating contemporary street art with murals, performances, and workshops.",
                EventTypeId = 5
            },
            new Event
            {
                Id = 25,
                Name = "Islamic Heritage Conference",
                Description = "A conference focusing on the historical and cultural significance of Islamic heritage in Egypt.",
                EventTypeId = 3
}
        };

        builder.HasData(events);
    }
}