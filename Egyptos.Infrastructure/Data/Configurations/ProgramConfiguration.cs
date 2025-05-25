using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TripsProgramConfiguration : IEntityTypeConfiguration<TripProgram>
{
    public void Configure(EntityTypeBuilder<TripProgram> builder)
    {
        var programs = new List<TripProgram>();

        // Classic Egypt Destinations for Spring/Summer Season
        var destinations = new[]
        {
            "Great Pyramid of Giza", "Sphinx", "Egyptian Museum", "Khan El Khalili", "Citadel of Saladin",
            "Karnak Temple", "Luxor Temple", "Valley of the Kings", "Philae Temple", "Abu Simbel",
            "Alexandria Library", "Pompey's Pillar", "Catacombs of Kom el Shoqafa", "Montaza Palace", "Qaitbay Citadel",
            "White Desert", "Siwa Oasis", "Temple of the Oracle", "Cleopatra's Bath", "Mountain of the Dead",
            "Hurghada Marina", "Giftun Island", "El Gouna", "Makadi Bay", "Sahl Hasheesh",
            "Sharm El Sheikh", "Ras Mohammed", "Naama Bay", "Dahab", "Mount Sinai",
            "Faiyum Oasis", "Wadi El Rayan", "Lake Qarun", "Pyramid of Meidum", "Lahun Pyramid",
            "Memphis", "Saqqara", "Dahshur", "Bent Pyramid", "Red Pyramid",
            "Edfu Temple", "Kom Ombo Temple", "Esna Temple", "Elephantine Island", "Nubian Village"
        };

        var activities = new[]
        {
            "Pyramid exploration", "Ancient hieroglyphs decoding", "Pharaonic history tour", "Egyptian archaeology workshop", "Mummy wrapping demonstration",
            "Nile felucca sailing", "Traditional fishing", "Sunset river cruise", "Nile island hopping", "Ancient boat building",
            "Snorkeling adventure", "Scuba diving expedition", "Coral reef photography", "Marine life observation", "Beach volleyball tournament",
            "Desert camel trekking", "Bedouin camp experience", "Star gazing session", "Sand dune surfing", "Oasis exploration",
            "Coptic Cairo walking tour", "Islamic architecture study", "Traditional craft workshop", "Local cuisine cooking class", "Bazaar shopping experience",
            "Temple sound and light show", "Ancient rituals reenactment", "Egyptian mythology storytelling", "Sacred geometry workshop", "Meditation at temples"
        };

        var descriptions = new[]
        {
            "Explore the mysteries of ancient Egyptian civilization", "Discover the wonders of the pharaohs",
            "Experience the magic of the eternal Nile River", "Adventure through Egypt's golden deserts",
            "Dive into the crystal clear waters of the Red Sea", "Uncover the secrets of Alexandria's ancient glory",
            "Journey through time in Egypt's sacred temples", "Immerse yourself in authentic Egyptian culture",
            "Archaeological adventure with expert guides", "Spiritual journey through Egypt's holy sites",
            "Photography expedition capturing Egypt's beauty", "Family-friendly exploration of Egyptian heritage",
            "Luxury experience of Egypt's timeless treasures", "Educational tour of Egypt's greatest monuments",
            "Cultural immersion in traditional Egyptian life", "Historical expedition through millennia of civilization"
        };

        var baseDate = new DateTime(2025, 1, 1); // Starting from beginning of year
        var random = new Random(42); // Fixed seed for consistency

        for (int tripId = 1; tripId <= 122; tripId++)
        {

            if (tripId == 79 || tripId == 80)
                continue;

            var tripIndex = tripId - 1;
            var tripStartDate = baseDate.AddDays(tripIndex * 2); // Every 2 days

            // Program 1: Morning Historical/Archaeological Experience
            programs.Add(new TripProgram
            {
                Id = tripIndex * 3 + 1, // Starting from ID 1
                Description = $"{descriptions[random.Next(descriptions.Length)]} - {activities[random.Next(0, 5)]}",
                Destination = destinations[random.Next(0, 15)], // Historical and archaeological sites
                StartDate = tripStartDate,
                EndDate = tripStartDate.AddDays(random.Next(2, 4)),
                TripId = tripId
            });

            // Program 2: Afternoon Adventure/Water Experience  
            programs.Add(new TripProgram
            {
                Id = tripIndex * 3 + 2,
                Description = $"{descriptions[random.Next(descriptions.Length)]} - {activities[random.Next(5, 20)]}",
                Destination = destinations[random.Next(15, 35)], // Adventure and water sites
                StartDate = tripStartDate.AddDays(1),
                EndDate = tripStartDate.AddDays(random.Next(3, 5)),
                TripId = tripId
            });

            // Program 3: Evening Cultural/Desert Experience
            programs.Add(new TripProgram
            {
                Id = tripIndex * 3 + 3,
                Description = $"{descriptions[random.Next(descriptions.Length)]} - {activities[random.Next(20, activities.Length)]}",
                Destination = destinations[random.Next(35, destinations.Length)], // Cultural and desert sites
                StartDate = tripStartDate.AddDays(2),
                EndDate = tripStartDate.AddDays(random.Next(4, 6)),
                TripId = tripId
            });
        }

        builder.HasData(programs);
    }
}