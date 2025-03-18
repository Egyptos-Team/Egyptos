using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddEventData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "EventTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "A festival celebrating Ismailia's famous mangoes with exhibitions and entertainment.", 4, "Ismailia Mango Festival" },
                    { 2, "A festival showcasing short films from Egypt and beyond, attracting filmmakers and critics.", 5, "Alexandria Short Film Festival" },
                    { 3, "A festival dedicated to women in theatre, featuring performances and discussions.", 5, "International Women Theatre Festival" },
                    { 4, "An astronomical event where the sun aligns with the temple’s axis, showcasing ancient Egyptian ingenuity.", 2, "The Solar Alignment on the Karnak Temple" },
                    { 5, "One of the Arab world's most prestigious film festivals, drawing filmmakers and critics.", 1, "Cairo International Film Festival" },
                    { 6, "A spectacular show narrating Egypt’s history using sound and light projections on the pyramids.", 2, "Giza Pyramids Sound and Light Show" },
                    { 7, "A festival celebrating Ramadan with beautiful lantern displays and cultural performances.", 3, "Ramadan Lantern Festival" },
                    { 8, "A vibrant summer festival with music, dance, and water activities along the Red Sea coast.", 4, "Hurghada Summer Festival" },
                    { 9, "A theatre festival featuring international performances, workshops, and panel discussions.", 1, "Sharm El Sheikh International Theatre Festival" },
                    { 10, "An exhibition displaying King Tutankhamun’s treasures, offering insights into his life and reign.", 2, "Tutankhamun Exhibition" },
                    { 11, "A religious festival celebrating Prophet Muhammad’s birth with prayers and parades.", 3, "Mawlid Al-Nabi Celebrations" },
                    { 12, "A cultural festival celebrating Egyptian heritage with traditional music and storytelling.", 4, "Sphinx Festival" },
                    { 13, "An international film festival held in El Gouna, featuring high-quality films and industry panels.", 1, "El Gouna Film Festival" },
                    { 14, "A grand parade transferring royal mummies to their new museum with spectacular performances.", 2, "Pharaohs' Golden Parade" },
                    { 15, "Nationwide celebrations marking the end of Ramadan with special prayers and cultural events.", 3, "Eid Al-Fitr Festivities" },
                    { 16, "A festival celebrating Nubian traditions with music, dance, and traditional crafts.", 4, "Aswan Nubian Festival" },
                    { 17, "An international squash tournament held in El Gouna, featuring top-ranked players.", 1, "Gouna Squash Open" },
                    { 18, "A major book fair attracting authors and publishers for literary discussions and signings.", 5, "Alexandria Book Fair" },
                    { 19, "A festival celebrating Siwa Oasis’ famous dates, featuring local crafts and traditions.", 4, "Siwa Date Festival" },
                    { 20, "A special exhibition marking the anniversary of the Egyptian Museum with rare artifacts on display.", 2, "Egyptian Museum Anniversary Exhibition" },
                    { 21, "A religious celebration of Coptic Christmas, featuring prayers, feasts, and community gatherings.", 3, "Coptic Christmas Celebrations" },
                    { 22, "An international kite surfing competition held on Egypt’s Red Sea coast, attracting top athletes.", 1, "Red Sea Kite Surfing Championship" },
                    { 23, "An annual exhibition displaying works from Egypt's top artists in the historic city of Luxor.", 5, "Luxor Art Exhibition" },
                    { 24, "A festival celebrating contemporary street art with murals, performances, and workshops.", 5, "Cairo Street Art Festival" },
                    { 25, "A conference focusing on the historical and cultural significance of Islamic heritage in Egypt.", 3, "Islamic Heritage Conference" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 25);
        }
    }
}
