using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddEventDateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EventDates",
                columns: new[] { "Id", "Description", "EndDate", "EndSubscription", "EventId", "IsActiveToSubscribe", "Location", "Price", "StartDate", "StartSubscription" },
                values: new object[,]
                {
                    { 1, "A festival celebrating Ismailia's famous mangoes with exhibitions and entertainment.", new DateTime(2025, 7, 10, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 9, 23, 59, 0, 0, DateTimeKind.Unspecified), 1, false, "Ismailia, Egypt", 100.0, new DateTime(2025, 7, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "A festival showcasing short films from Egypt and beyond, attracting filmmakers and critics.", new DateTime(2025, 4, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 10, 23, 59, 0, 0, DateTimeKind.Unspecified), 2, true, "Alexandria, Egypt", 150.0, new DateTime(2025, 4, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "A festival dedicated to women in theatre, featuring performances and discussions.", new DateTime(2025, 3, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 5, 23, 59, 0, 0, DateTimeKind.Unspecified), 3, false, "Cairo, Egypt", 120.0, new DateTime(2025, 3, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "An astronomical event where the sun aligns with the temple’s axis, showcasing ancient Egyptian ingenuity.", new DateTime(2025, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 18, 23, 59, 0, 0, DateTimeKind.Unspecified), 4, false, "Karnak Temple, Luxor, Egypt", 250.0, new DateTime(2025, 2, 21, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "One of the Arab world's most prestigious film festivals, drawing filmmakers and critics.", new DateTime(2025, 11, 20, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 5, 23, 59, 0, 0, DateTimeKind.Unspecified), 5, false, "Cairo, Egypt", 200.0, new DateTime(2025, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "A spectacular show narrating Egypt’s history using sound and light projections on the pyramids.", new DateTime(2025, 5, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 30, 23, 59, 0, 0, DateTimeKind.Unspecified), 6, false, "Giza Pyramids, Egypt", 180.0, new DateTime(2025, 5, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "A festival celebrating Ramadan with beautiful lantern displays and cultural performances.", new DateTime(2025, 4, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 23, 23, 59, 0, 0, DateTimeKind.Unspecified), 7, true, "Cairo, Egypt", 80.0, new DateTime(2025, 3, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "A vibrant summer festival with music, dance, and water activities along the Red Sea coast.", new DateTime(2025, 8, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 10, 23, 59, 0, 0, DateTimeKind.Unspecified), 8, false, "Hurghada, Egypt", 150.0, new DateTime(2025, 8, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "A theatre festival featuring international performances, workshops, and panel discussions.", new DateTime(2025, 12, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 1, 23, 59, 0, 0, DateTimeKind.Unspecified), 9, false, "Sharm El Sheikh, Egypt", 170.0, new DateTime(2025, 12, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "An exhibition showcasing the treasures of King Tutankhamun.", new DateTime(2025, 3, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 10, 23, 59, 59, 0, DateTimeKind.Unspecified), 10, false, "Cairo Museum", 300.0, new DateTime(2025, 3, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Religious festival celebrating Prophet Muhammad’s birth.", new DateTime(2025, 9, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 20, 23, 59, 59, 0, DateTimeKind.Unspecified), 11, false, "Al Azhar Mosque", 0.0, new DateTime(2025, 9, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "A cultural festival celebrating Egyptian heritage.", new DateTime(2025, 6, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), 12, false, "Giza Plateau", 150.0, new DateTime(2025, 6, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "A prestigious international film festival held in El Gouna.", new DateTime(2025, 10, 28, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 15, 23, 59, 59, 0, DateTimeKind.Unspecified), 13, false, "El Gouna, Red Sea", 500.0, new DateTime(2025, 10, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "A grand parade transferring royal mummies to their new museum with spectacular performances.", new DateTime(2025, 9, 24, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 19, 23, 59, 59, 0, DateTimeKind.Unspecified), 14, false, "Cairo, Egypt", 450.0, new DateTime(2025, 9, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Eid al-Fitr in Egypt is a major religious and cultural event that celebrates the end of Ramadan, the Islamic holy month of fasting.", new DateTime(2025, 4, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "Egypt", 150.0, new DateTime(2025, 3, 31, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 17, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "​The Aswan International Cultural Festival is an annual event celebrating the rich heritage of Nubian culture through music, dance, and art.", new DateTime(2025, 2, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 30, 7, 50, 0, 0, DateTimeKind.Unspecified), 16, false, "Aswan, Egypt", 500.0, new DateTime(2025, 2, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 19, 7, 50, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "​The El Gouna International Squash Open is a premier event on the Professional Squash Association (PSA) World Tour, attracting top players from around the globe.", new DateTime(2025, 4, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "El Gouna, Egypt", 1100.0, new DateTime(2025, 4, 12, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "The Bibliotheca Alexandrina International Book Fair is an annual cultural event celebrating literature, arts, and intellectual exchange.", new DateTime(2025, 7, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 18, false, "Alexandria, Egypt", 100.0, new DateTime(2025, 7, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "​The Siwa Date Festival is an annual celebration held in Siwa Oasis, Egypt, honoring the region's rich tradition of date cultivation. This event showcases the oasis's cultural heritage and agricultural significance.", new DateTime(2025, 10, 17, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 19, false, "Siwa, Egypt", 200.0, new DateTime(2025, 10, 15, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "​The Egyptian Museum in Cairo, established in 1902, is renowned for its extensive collection of ancient Egyptian artifacts.", new DateTime(2025, 7, 3, 10, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 20, false, "Cairo, Egypt", 250.0, new DateTime(2025, 7, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 15, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, "Coptic Christmas is a time of profound spiritual reflection and communal celebration, deeply rooted in Egypt's rich Christian heritage, it's celebrated by the Coptic Orthodox Church in Egypt", new DateTime(2025, 1, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 21, false, "Egypt", 100.0, new DateTime(2025, 1, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "​The Red Sea region in Egypt is renowned for its vibrant kitesurfing scene, hosting various events and safaris throughout the year.", new DateTime(2025, 4, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 22, false, "Red Sea, Egypt", 500.0, new DateTime(2025, 4, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, "The Luxor Spring Arts Festival aims to celebrate both contemporary and traditional Egyptian art, providing a platform for local and international artists to showcase their work.​", new DateTime(2025, 7, 21, 10, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 23, false, "Luxor, Egypt", 450.0, new DateTime(2025, 7, 16, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 3, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, "Art Cairo is an annual art fair that showcases contemporary and modern Arab art, providing a platform for artists from Egypt and the broader region to present their work.", new DateTime(2025, 2, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "Cairo, Egypt", 150.0, new DateTime(2025, 2, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, " This conference aims to explore various aspects of Islam and its cultural manifestations.​", new DateTime(2025, 11, 29, 10, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "Alexandria, Egypt", 200.0, new DateTime(2025, 11, 29, 1, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 20, 8, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 25);
        }
    }
}
