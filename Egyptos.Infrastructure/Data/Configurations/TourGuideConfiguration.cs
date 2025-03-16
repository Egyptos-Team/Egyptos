using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Egyptos.Domain.Entities;

namespace Egyptos.Infrastructure.Data.Configurations;

public class TourGuideConfiguration : IEntityTypeConfiguration<TourGuide>
{
    public void Configure(EntityTypeBuilder<TourGuide> builder)
    {
        var tourGuides = new List<TourGuide>
        {
            new TourGuide
            {
                Id = 1,
                SalaryPerHour = 150,
                Description = "A passionate tour guide with in-depth knowledge of historical landmarks and cultural heritage, dedicated to providing engaging and educational experiences.",
                YearsOfExperience = 1,
                UserId = "683211b1-1125-42a1-b148-a606a4ca4df3",
            },
            new TourGuide
            {
                Id = 2,
                SalaryPerHour = 150,
                Description = "Experienced tour guide specializing in archaeological sites, offering insightful narratives that bring history to life.",
                YearsOfExperience = 1,
                UserId = "df2ea217-2e82-48b9-9442-47556c1a9403",
            },
            new TourGuide
            {
                Id = 3,
                SalaryPerHour = 150,
                Description = "Friendly and knowledgeable guide, ensuring every visitor enjoys a personalized and immersive travel experience.",
                YearsOfExperience = 1,
                UserId = "6b9b3e85-ce32-4944-9a46-601bb2b40000",
            },
            new TourGuide
            {
                Id = 4,
                SalaryPerHour = 150,
                Description = "Expert in local history and traditions, delivering memorable tours that blend education and entertainment.",
                YearsOfExperience = 1,
                UserId = "fc4df06f-05c2-4751-96c1-8040f2761b7f",
            },
            new TourGuide
            {
                Id = 5,
                SalaryPerHour = 150,
                Description = "A dynamic storyteller who transforms every tour into a fascinating journey through time and culture.",
                YearsOfExperience = 1,
                UserId = "7c30ae16-67eb-4ff2-858f-70aa79aaa3c4",
            },
            new TourGuide
            {
                Id = 6,
                SalaryPerHour = 300,
                Description = "Fluent in multiple languages, offering exceptional guided experiences for travelers from around the world.",
                YearsOfExperience = 2,
                UserId = "ce47a5ab-df14-416a-b500-9b544fa666a4",
            },new TourGuide
            {
                Id = 7,
                SalaryPerHour = 300,
                Description = "Skilled in adventure tourism, leading exciting and informative tours through natural wonders and historical landmarks.",
                YearsOfExperience = 2,
                UserId = "249aa6c5-d578-4517-8a42-48f24a7d959e",
            },
            new TourGuide
            {
                Id = 8,
                SalaryPerHour = 300,
                Description = "Passionate about sharing hidden gems and off-the-beaten-path locations with travelers seeking authentic experiences.",
                YearsOfExperience = 2,
                UserId = "49a438ba-672d-41d5-97ba-5536ffbec2a6",
            },new TourGuide
            {
                Id = 9,
                SalaryPerHour = 300,
                Description = "A certified tour guide with years of experience, ensuring visitors gain deep insights into historical and modern attractions.",
                YearsOfExperience = 2,
                UserId = "bf2ee728-59af-45ec-9b70-e5f5e27eef8e",
            },
            new TourGuide
            {
                Id = 10,
                SalaryPerHour = 300,
                Description = "Dedicated to providing an unforgettable journey through historical sites, blending education with entertainment.",
                YearsOfExperience = 2,
                UserId = "cb3cb7ca-1921-49fd-a11e-600b351b3df2",
            },new TourGuide
            {
                Id = 11,
                SalaryPerHour = 500,
                Description = "An enthusiastic guide who loves connecting people with the rich history and traditions of the region.",
                YearsOfExperience = 3,
                UserId = "cb3cb7ca-1921-49fd-a11e-600b351b3df3",
            },
            new TourGuide
            {
                Id = 12,
                SalaryPerHour = 500,
                Description = "Expert in eco-tourism, offering sustainable and immersive travel experiences for nature lovers.",
                YearsOfExperience = 3,
                UserId = "5d577849-97d1-4984-bf96-6fee7d08c8be",
            },new TourGuide
            {
                Id = 13,
                SalaryPerHour = 500,
                Description = "Combining storytelling with historical facts to create engaging and interactive guided tours.",
                YearsOfExperience = 3,
                UserId = "f89bca4a-8fc9-4259-a46d-22562907c27f",
            },
            new TourGuide
            {
                Id = 14,
                SalaryPerHour = 500,
                Description = "A charismatic and knowledgeable guide, ensuring tourists leave with a deeper appreciation for the destination.",
                YearsOfExperience = 3,
                UserId = "cb3cb7ca-1921-49fd-a11e-600b351b3df4",
            },new TourGuide
            {
                Id = 15,
                SalaryPerHour = 500,
                Description = "Certified heritage interpreter, offering in-depth explorations of ancient and modern cultural landmarks.",
                YearsOfExperience = 3,
                UserId = "8766c317-1eaa-468a-b34d-59790c8eb915",
            },
            new TourGuide
            {
                Id = 16,
                SalaryPerHour = 4000,
                Description = "Well-versed in local customs, history, and cuisine, providing a holistic travel experience for every visitor.",
                YearsOfExperience = 4,
                UserId = "52511e3a-0690-45b0-9e52-02667a473b18",
            },new TourGuide
            {
                Id = 17,
                SalaryPerHour = 750,
                Description = "Professional and friendly guide who creates customized tours to meet the interests of each group.",
                YearsOfExperience = 5,
                UserId = "a0e2f1e7-53e5-416f-b0b0-ca4668563233",
            },
            new TourGuide
            {
                Id = 18,
                SalaryPerHour = 700,
                Description = "A history enthusiast dedicated to making every tour an unforgettable and enriching experience.",
                YearsOfExperience = 4,
                UserId = "357c8ce0-ed6e-4979-b1f9-5e0f6e90c9a1",
            },
            new TourGuide
            {
                Id = 19,
                SalaryPerHour = 750,
                Description = "Providing top-tier guided tours that blend adventure, history, and culture for an unforgettable experience.",
                YearsOfExperience = 5,
                UserId = "10eb7637-95f4-45d2-b200-84dbb188ec41",
            }
        };

        builder.HasData(tourGuides);
    }
}