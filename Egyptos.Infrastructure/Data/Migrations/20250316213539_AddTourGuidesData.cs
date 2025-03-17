using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTourGuidesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TourGuides",
                columns: new[] { "Id", "Description", "IsActive", "IsAvailable", "Rate", "SalaryPerHour", "UserId", "YearsOfExperience" },
                values: new object[,]
                {
                    { 1, "A passionate tour guide with in-depth knowledge of historical landmarks and cultural heritage, dedicated to providing engaging and educational experiences.", true, true, 3.0, 150.0, "683211b1-1125-42a1-b148-a606a4ca4df3", 1 },
                    { 2, "Experienced tour guide specializing in archaeological sites, offering insightful narratives that bring history to life.", true, true, 3.0, 150.0, "df2ea217-2e82-48b9-9442-47556c1a9403", 1 },
                    { 3, "Friendly and knowledgeable guide, ensuring every visitor enjoys a personalized and immersive travel experience.", true, true, 3.0, 150.0, "6b9b3e85-ce32-4944-9a46-601bb2b40000", 1 },
                    { 4, "Expert in local history and traditions, delivering memorable tours that blend education and entertainment.", true, true, 3.0, 150.0, "fc4df06f-05c2-4751-96c1-8040f2761b7f", 1 },
                    { 5, "A dynamic storyteller who transforms every tour into a fascinating journey through time and culture.", true, true, 3.0, 150.0, "7c30ae16-67eb-4ff2-858f-70aa79aaa3c4", 1 },
                    { 6, "Fluent in multiple languages, offering exceptional guided experiences for travelers from around the world.", true, true, 3.0, 300.0, "ce47a5ab-df14-416a-b500-9b544fa666a4", 2 },
                    { 7, "Skilled in adventure tourism, leading exciting and informative tours through natural wonders and historical landmarks.", true, true, 3.0, 300.0, "249aa6c5-d578-4517-8a42-48f24a7d959e", 2 },
                    { 8, "Passionate about sharing hidden gems and off-the-beaten-path locations with travelers seeking authentic experiences.", true, true, 3.0, 300.0, "49a438ba-672d-41d5-97ba-5536ffbec2a6", 2 },
                    { 9, "A certified tour guide with years of experience, ensuring visitors gain deep insights into historical and modern attractions.", true, true, 3.0, 300.0, "bf2ee728-59af-45ec-9b70-e5f5e27eef8e", 2 },
                    { 10, "Dedicated to providing an unforgettable journey through historical sites, blending education with entertainment.", true, true, 3.0, 300.0, "cb3cb7ca-1921-49fd-a11e-600b351b3df2", 2 },
                    { 11, "An enthusiastic guide who loves connecting people with the rich history and traditions of the region.", true, true, 3.0, 500.0, "cb3cb7ca-1921-49fd-a11e-600b351b3df3", 3 },
                    { 12, "Expert in eco-tourism, offering sustainable and immersive travel experiences for nature lovers.", true, true, 3.0, 500.0, "5d577849-97d1-4984-bf96-6fee7d08c8be", 3 },
                    { 13, "Combining storytelling with historical facts to create engaging and interactive guided tours.", true, true, 3.0, 500.0, "f89bca4a-8fc9-4259-a46d-22562907c27f", 3 },
                    { 14, "A charismatic and knowledgeable guide, ensuring tourists leave with a deeper appreciation for the destination.", true, true, 3.0, 500.0, "cb3cb7ca-1921-49fd-a11e-600b351b3df4", 3 },
                    { 15, "Certified heritage interpreter, offering in-depth explorations of ancient and modern cultural landmarks.", true, true, 3.0, 500.0, "8766c317-1eaa-468a-b34d-59790c8eb915", 3 },
                    { 16, "Well-versed in local customs, history, and cuisine, providing a holistic travel experience for every visitor.", true, true, 3.0, 4000.0, "52511e3a-0690-45b0-9e52-02667a473b18", 4 },
                    { 17, "Professional and friendly guide who creates customized tours to meet the interests of each group.", true, true, 3.0, 750.0, "a0e2f1e7-53e5-416f-b0b0-ca4668563233", 5 },
                    { 18, "A history enthusiast dedicated to making every tour an unforgettable and enriching experience.", true, true, 3.0, 700.0, "357c8ce0-ed6e-4979-b1f9-5e0f6e90c9a1", 4 },
                    { 19, "Providing top-tier guided tours that blend adventure, history, and culture for an unforgettable experience.", true, true, 3.0, 750.0, "10eb7637-95f4-45d2-b200-84dbb188ec41", 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TourGuides",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TourGuides",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TourGuides",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TourGuides",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TourGuides",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TourGuides",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TourGuides",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TourGuides",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TourGuides",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TourGuides",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TourGuides",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TourGuides",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TourGuides",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TourGuides",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TourGuides",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TourGuides",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TourGuides",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TourGuides",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TourGuides",
                keyColumn: "Id",
                keyValue: 19);
        }
    }
}
