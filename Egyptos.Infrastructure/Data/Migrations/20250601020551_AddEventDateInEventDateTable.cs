using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddEventDateInEventDateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EndDate", "Location", "Price", "StartDate" },
                values: new object[] { "The Grand Opening Ceremony of the Grand Egyptian Museum in Giza, Egypt. This monumental event will showcase the museum’s most anticipated exhibits, including the full collection of King Tutankhamun’s treasures. The event will feature official speeches, cultural performances, a tour of the museum’s galleries, and a stunning multimedia light show celebrating Egypt's ancient heritage. Attendees will include international leaders, scholars, and celebrities, marking a historic moment in Egypt’s cultural and touristic landscape.", new DateTime(2025, 11, 12, 23, 59, 0, 0, DateTimeKind.Unspecified), "Giza, Egypt", 500.0, new DateTime(2025, 11, 10, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EndDate", "EndSubscription", "Location", "Price", "StartDate", "StartSubscription" },
                values: new object[] { "The Royal Mummies Parade is a majestic night event in Cairo, showcasing the transfer of 22 ancient Egyptian royal mummies in beautifully decorated carriages, accompanied by traditional music and celebrations. This unique event highlights Egypt’s ancient civilization and cultural pride.", new DateTime(2024, 4, 3, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 23, 59, 0, 0, DateTimeKind.Unspecified), "From Tahrir Square to the National Museum of Egyptian Civilization, Cairo", 300.0, new DateTime(2024, 4, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EndDate", "EndSubscription", "Location", "Price", "StartDate", "StartSubscription" },
                values: new object[] { "The FIFA World Cup 2030 hosted by Egypt will feature matches in state-of-the-art stadiums in Cairo, Alexandria, and other cities. Fans will enjoy a blend of thrilling football action and rich Egyptian culture and hospitality throughout the month-long tournament.", new DateTime(2030, 7, 15, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 6, 9, 23, 59, 0, 0, DateTimeKind.Unspecified), "Various cities across Egypt", 1500.0, new DateTime(2030, 6, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2029, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EndDate", "EndSubscription", "Location", "Price", "StartDate", "StartSubscription" },
                values: new object[] { "The Cross Egypt Challenge is a demanding motorcycle rally through Sinai’s diverse terrain, covering 2,900 km over 8 stages. Riders will encounter desert landscapes, mountains, and coastal roads, experiencing the best of Egypt’s natural beauty and cultural richness.", new DateTime(2025, 10, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 25, 23, 59, 59, 0, DateTimeKind.Unspecified), "Sinai Peninsula, Egypt", 2500.0, new DateTime(2025, 10, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "EndDate", "EndSubscription", "Location", "Price", "StartDate", "StartSubscription" },
                values: new object[] { "The Zamna Festival is a landmark electronic music event bringing artists like Adriatique, Collé, and Mayssa to Egypt for the first time. Held near the iconic Giza Pyramids, it blends world-class music with Egypt’s ancient heritage.", new DateTime(2025, 12, 26, 2, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 24, 23, 59, 59, 0, DateTimeKind.Unspecified), "Foot of the Giza Pyramids, Cairo, Egypt", 700.0, new DateTime(2025, 12, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "EventDates",
                columns: new[] { "Id", "Description", "EndDate", "EndSubscription", "EventId", "IsActiveToSubscribe", "Location", "Price", "StartDate", "StartSubscription" },
                values: new object[,]
                {
                    { 31, "A delightful celebration of Ismailia's world-renowned mangoes, featuring extensive agricultural exhibitions showcasing different mango varieties, traditional harvesting demonstrations, cooking competitions with mango-based dishes, live folk music performances, and family-friendly entertainment. Local farmers display their finest produce while visitors can sample fresh mango juices, dried mango products, and traditional Egyptian sweets infused with mango flavors. The festival also includes cultural workshops on mango cultivation techniques and the fruit's significance in Egyptian agriculture.", new DateTime(2025, 7, 10, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 9, 23, 59, 0, 0, DateTimeKind.Unspecified), 31, false, "Ismailia, Egypt", 100.0, new DateTime(2025, 7, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, "An internationally acclaimed film festival that transforms Alexandria into a cinematic hub, showcasing innovative short films from Egyptian and international filmmakers. The event features competitive screenings across multiple venues, masterclasses with renowned directors, industry networking sessions, and panel discussions on contemporary filmmaking techniques. Emerging filmmakers get the opportunity to present their work to industry professionals, critics, and cinema enthusiasts. The festival also includes workshops on digital filmmaking, script writing, and post-production techniques, making it a comprehensive learning experience for aspiring filmmakers.", new DateTime(2025, 10, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 10, 23, 59, 0, 0, DateTimeKind.Unspecified), 32, false, "Alexandria, Egypt", 150.0, new DateTime(2025, 10, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, "A groundbreaking festival dedicated to celebrating women's contributions to theatre arts, featuring powerful performances by female playwrights, directors, and actresses from around the world. The festival presents thought-provoking plays addressing women's experiences, social issues, and contemporary challenges. Interactive workshops cover topics such as feminist theatre, directing techniques, and creative writing. Panel discussions bring together theatre professionals to explore gender representation in performing arts, while networking events connect women in theatre from different cultural backgrounds. The festival also includes community outreach programs promoting theatre education among young women.", new DateTime(2025, 3, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 5, 23, 59, 0, 0, DateTimeKind.Unspecified), 33, false, "Cairo, Egypt", 120.0, new DateTime(2025, 3, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, "A breathtaking astronomical phenomenon that occurs twice yearly when the rising sun perfectly aligns with the main axis of Karnak Temple, illuminating the sacred sanctuary in golden light. This ancient engineering marvel demonstrates the sophisticated astronomical knowledge of pharaonic architects who designed the temple to capture this celestial event. Visitors gather before dawn to witness this mystical moment, accompanied by expert Egyptologists who explain the religious and astronomical significance of the alignment. The event includes guided tours of the temple complex, lectures on ancient Egyptian astronomy, photography workshops, and cultural performances recreating ancient rituals that would have accompanied this sacred occurrence.", new DateTime(2025, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 18, 23, 59, 0, 0, DateTimeKind.Unspecified), 34, false, "Karnak Temple, Luxor, Egypt", 250.0, new DateTime(2025, 2, 21, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, "The Arab world's most prestigious and longest-running film festival, transforming Cairo into the region's cinematic capital for two weeks each year. This internationally recognized event attracts A-list celebrities, renowned directors, producers, and film critics from around the globe. The festival screens hundreds of films across various categories including feature films, documentaries, and short films, with competitions for both regional and international productions. Red carpet galas, exclusive premieres, industry forums, and film market sessions provide networking opportunities for industry professionals. Educational programs include film workshops, master classes with acclaimed directors, and seminars on the future of Arab cinema.", new DateTime(2025, 11, 20, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 5, 23, 59, 0, 0, DateTimeKind.Unspecified), 35, false, "Cairo, Egypt", 200.0, new DateTime(2025, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventId",
                value: 31);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "EventId",
                value: 31);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "EventId",
                value: 31);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "EventId",
                value: 32);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "EventId",
                value: 32);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "EventId",
                value: 32);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "EventId",
                value: 33);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "EventId",
                value: 33);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "EventId",
                value: 33);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "EventId",
                value: 34);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "EventId",
                value: 34);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "EventId",
                value: 34);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "EventId",
                value: 35);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "EventId",
                value: 35);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "EventId",
                value: 35);

            migrationBuilder.InsertData(
                table: "EventImages",
                columns: new[] { "Id", "EventId", "ImageUrl" },
                values: new object[,]
                {
                    { 100, 1, "EventImages/WhatsApp Image 2025-06-01 at 04.33.41_8bcceded.jpg" },
                    { 101, 1, "EventImages/WhatsApp Image 2025-06-01 at 04.33.42_88f42345.jpg" },
                    { 102, 1, "EventImages/WhatsApp Image 2025-06-01 at 04.33.42_61530aab.jpg" },
                    { 103, 2, "EventImages/AA.jpg" },
                    { 104, 2, "EventImages/AAA.jpg" },
                    { 105, 3, "EventImages/B.jpg" },
                    { 106, 3, "EventImages/BB.jpg" },
                    { 107, 3, "EventImages/BBB.jpg" },
                    { 108, 4, "EventImages/C.jpg" },
                    { 109, 4, "EventImages/CC.jpg" },
                    { 110, 4, "EventImages/CCC.jpg" },
                    { 111, 5, "EventImages/D.jpg" },
                    { 112, 5, "EventImages/DD.jpg" },
                    { 113, 5, "EventImages/DDD.jpg" },
                    { 114, 2, "EventImages/A.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EndDate", "Location", "Price", "StartDate" },
                values: new object[] { "A delightful celebration of Ismailia's world-renowned mangoes, featuring extensive agricultural exhibitions showcasing different mango varieties, traditional harvesting demonstrations, cooking competitions with mango-based dishes, live folk music performances, and family-friendly entertainment. Local farmers display their finest produce while visitors can sample fresh mango juices, dried mango products, and traditional Egyptian sweets infused with mango flavors. The festival also includes cultural workshops on mango cultivation techniques and the fruit's significance in Egyptian agriculture.", new DateTime(2025, 7, 10, 23, 59, 0, 0, DateTimeKind.Unspecified), "Ismailia, Egypt", 100.0, new DateTime(2025, 7, 10, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EndDate", "EndSubscription", "Location", "Price", "StartDate", "StartSubscription" },
                values: new object[] { "An internationally acclaimed film festival that transforms Alexandria into a cinematic hub, showcasing innovative short films from Egyptian and international filmmakers. The event features competitive screenings across multiple venues, masterclasses with renowned directors, industry networking sessions, and panel discussions on contemporary filmmaking techniques. Emerging filmmakers get the opportunity to present their work to industry professionals, critics, and cinema enthusiasts. The festival also includes workshops on digital filmmaking, script writing, and post-production techniques, making it a comprehensive learning experience for aspiring filmmakers.", new DateTime(2025, 10, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 10, 23, 59, 0, 0, DateTimeKind.Unspecified), "Alexandria, Egypt", 150.0, new DateTime(2025, 10, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EndDate", "EndSubscription", "Location", "Price", "StartDate", "StartSubscription" },
                values: new object[] { "A groundbreaking festival dedicated to celebrating women's contributions to theatre arts, featuring powerful performances by female playwrights, directors, and actresses from around the world. The festival presents thought-provoking plays addressing women's experiences, social issues, and contemporary challenges. Interactive workshops cover topics such as feminist theatre, directing techniques, and creative writing. Panel discussions bring together theatre professionals to explore gender representation in performing arts, while networking events connect women in theatre from different cultural backgrounds. The festival also includes community outreach programs promoting theatre education among young women.", new DateTime(2025, 3, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 5, 23, 59, 0, 0, DateTimeKind.Unspecified), "Cairo, Egypt", 120.0, new DateTime(2025, 3, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EndDate", "EndSubscription", "Location", "Price", "StartDate", "StartSubscription" },
                values: new object[] { "A breathtaking astronomical phenomenon that occurs twice yearly when the rising sun perfectly aligns with the main axis of Karnak Temple, illuminating the sacred sanctuary in golden light. This ancient engineering marvel demonstrates the sophisticated astronomical knowledge of pharaonic architects who designed the temple to capture this celestial event. Visitors gather before dawn to witness this mystical moment, accompanied by expert Egyptologists who explain the religious and astronomical significance of the alignment. The event includes guided tours of the temple complex, lectures on ancient Egyptian astronomy, photography workshops, and cultural performances recreating ancient rituals that would have accompanied this sacred occurrence.", new DateTime(2025, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 18, 23, 59, 0, 0, DateTimeKind.Unspecified), "Karnak Temple, Luxor, Egypt", 250.0, new DateTime(2025, 2, 21, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "EndDate", "EndSubscription", "Location", "Price", "StartDate", "StartSubscription" },
                values: new object[] { "The Arab world's most prestigious and longest-running film festival, transforming Cairo into the region's cinematic capital for two weeks each year. This internationally recognized event attracts A-list celebrities, renowned directors, producers, and film critics from around the globe. The festival screens hundreds of films across various categories including feature films, documentaries, and short films, with competitions for both regional and international productions. Red carpet galas, exclusive premieres, industry forums, and film market sessions provide networking opportunities for industry professionals. Educational programs include film workshops, master classes with acclaimed directors, and seminars on the future of Arab cinema.", new DateTime(2025, 11, 20, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 5, 23, 59, 0, 0, DateTimeKind.Unspecified), "Cairo, Egypt", 200.0, new DateTime(2025, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "EventId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "EventId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "EventId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "EventId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "EventId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "EventId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "EventId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "EventId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "EventId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "EventId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "EventId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "EventId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "EventId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "EventImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "EventId",
                value: 5);
        }
    }
}
