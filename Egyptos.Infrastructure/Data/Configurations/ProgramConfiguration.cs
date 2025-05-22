
using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class NewTripsProgramConfiguration : IEntityTypeConfiguration<TripProgram>
{
    public void Configure(EntityTypeBuilder<TripProgram> builder)
    {
        var programs = new List<TripProgram>();

        // Enhanced Egypt Destinations for Fall/Winter Season
        var destinations = new[]
        {
            "Temple of Hatshepsut", "Valley of the Queens", "Tombs of the Nobles", "Deir el-Bahari", "Malkata Palace",
            "Seti I Temple", "Ramses III Temple", "Amenhotep III Temple", "Luxor Museum", "Mummification Museum",
            "Aswan Botanical Garden", "Tomb of the Aga Khan", "Fatimid Cemetery", "Monastery of St. Simeon", "Kalabsha Temple",
            "Wadi El Natrun Monasteries", "Monastery of Saint Macarius", "Monastery of Saint Bishoy", "Desert of the Fathers", "Scetis Desert",
            "Ras El Bar", "Damietta", "Rosetta Stone Site", "Lake Burullus", "Baltim Beach",
            "Taba Heights", "Nuweiba", "Saint Catherine's Protectorate", "Colored Canyon", "Blue Desert",
            "Gilf Kebir Plateau", "Cave of Swimmers", "Crystal Mountain", "Black Desert", "English Mountain",
            "Wadi Degla Protectorate", "Petrified Forest", "Valley of the Whales", "Magic Lake", "Salt Lakes",
            "Berenice", "Gebel Elba", "Red Sea Mountains", "Emerald Mines", "Temple of Seti I at Kanais",
            "Dendera Archaeological Site", "Qena", "Coptos", "Nag Hammadi", "Dishna"
        };

        var activities = new[]
        {
            "Royal tomb exploration", "Ancient art workshop", "Hieratic script learning", "Royal mummy viewing", "Pharaonic jewelry crafting",
            "Monastery spiritual retreat", "Coptic art appreciation", "Desert hermitage visit", "Religious manuscript study", "Icon painting workshop",
            "Red Sea coral diving", "Deep sea fishing", "Underwater cave exploration", "Marine sanctuary visit", "Dolphin watching cruise",
            "Sahara expedition", "Fossil hunting", "Geological survey", "Meteorite site visit", "Ancient lake exploration",
            "Nile wildlife safari", "Bird watching expedition", "Wetland ecosystem study", "Endemic species observation", "Conservation project visit",
            "Traditional weaving", "Pottery making", "Metalwork crafting", "Carpet weaving", "Glass blowing workshop"
        };

        var descriptions = new[]
        {
            "Journey into the heart of pharaonic royalty", "Discover hidden treasures of ancient Egypt",
            "Experience the solitude of desert monasticism", "Explore pristine coral reefs and marine life",
            "Uncover geological wonders of the Western Desert", "Navigate the sacred waters of the Nile Delta",
            "Adventure through Egypt's untouched wilderness", "Immerse in traditional Egyptian craftsmanship",
            "Archaeological expedition with cutting-edge discoveries", "Spiritual pilgrimage through Christian Egypt",
            "Marine biology adventure in protected waters", "Desert survival and navigation experience",
            "Photography safari capturing Egypt's biodiversity", "Cultural exchange with Nubian communities",
            "Historical research expedition", "Eco-tourism and conservation awareness journey"
        };

        var baseDate = new DateTime(2025, 9, 12); // Starting from first new trip date
        var random = new Random(123); // Different seed for new trips

        for (int tripId = 123; tripId <= 150; tripId++)
        {
            var tripIndex = tripId - 123;
            var tripStartDate = baseDate.AddDays(tripIndex * 2); // Every 2 days like the trips

            // Program 1: Morning Royal/Archaeological Experience
            programs.Add(new TripProgram
            {
                Id = (tripId - 123) * 3 + 1, // Starting from ID 1
                Description = $"{descriptions[random.Next(descriptions.Length)]} - {activities[random.Next(0, 5)]}",
                Destination = destinations[random.Next(0, 15)], // Royal and archaeological sites
                StartDate = tripStartDate,
                EndDate = tripStartDate.AddDays(random.Next(2, 4)),
                TripId = tripId
            });

            // Program 2: Afternoon Adventure/Nature Experience  
            programs.Add(new TripProgram
            {
                Id = (tripId - 123) * 3 + 2,
                Description = $"{descriptions[random.Next(descriptions.Length)]} - {activities[random.Next(5, 20)]}",
                Destination = destinations[random.Next(15, 35)], // Adventure and nature sites
                StartDate = tripStartDate.AddDays(1),
                EndDate = tripStartDate.AddDays(random.Next(3, 5)),
                TripId = tripId
            });

            // Program 3: Evening Cultural/Spiritual Experience
            programs.Add(new TripProgram
            {
                Id = (tripId - 123) * 3 + 3,
                Description = $"{descriptions[random.Next(descriptions.Length)]} - {activities[random.Next(20, activities.Length)]}",
                Destination = destinations[random.Next(35, destinations.Length)], // Cultural and craft sites
                StartDate = tripStartDate.AddDays(2),
                EndDate = tripStartDate.AddDays(random.Next(4, 6)),
                TripId = tripId
            });
        }

        builder.HasData(programs);
    }
}

