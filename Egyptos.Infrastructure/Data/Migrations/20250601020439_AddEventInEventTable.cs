using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddEventInEventTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EventTypeId", "Name" },
                values: new object[] { "The Grand Egyptian Museum will officially open on July 3, 2025, in a prestigious ceremony attended by world leaders, dignitaries, and cultural figures. This major cultural event marks the unveiling of the museum’s vast collection, including the complete treasures of King Tutankhamun displayed together for the first time. The museum represents a new era in showcasing Egypt’s ancient heritage on a global stage.", 2, "Grand Egyptian Museum Official Opening" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EventTypeId", "Name" },
                values: new object[] { "A spectacular cultural event where 22 royal mummies are transferred from the Egyptian Museum in Tahrir to the National Museum of Egyptian Civilization in Fustat. The parade features elaborate carriages, traditional music, light shows, and a grand procession through Cairo’s main streets, celebrating Egypt’s glorious ancient heritage and attracting global attention.", 2, "Royal Mummies Parade" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EventTypeId", "Name" },
                values: new object[] { "Egypt will proudly co-host the FIFA World Cup 2030, welcoming football fans from around the globe to experience the world’s biggest sporting event. The tournament promises thrilling matches across multiple cities, showcasing Egypt’s rich culture, modern stadiums, and warm hospitality. This marks a historic milestone as Africa hosts the World Cup for the first time in decades.", 1, "FIFA World Cup 2030 – Egypt Host" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EventTypeId", "Name" },
                values: new object[] { "An exhilarating motorcycle rally spanning 8 stages over 2,900 km across Sinai, showcasing Egypt’s stunning natural landscapes and rich cultural heritage. Participants will experience challenging terrains and breathtaking views in this iconic endurance event.", 1, "Cross Egypt Challenge" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "EventTypeId", "Name" },
                values: new object[] { "A globally renowned electronic music festival held for the first time in Egypt, set at the foot of the Giza Pyramids. The festival features top international and local artists performing immersive sets in a unique historic atmosphere.", 4, "Zamna Festival" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "EventTypeId", "Name" },
                values: new object[,]
                {
                    { 31, "A delightful celebration of Ismailia's world-renowned mangoes, featuring extensive agricultural exhibitions showcasing different mango varieties, traditional harvesting demonstrations, cooking competitions with mango-based dishes, live folk music performances, and family-friendly entertainment. Local farmers display their finest produce while visitors can sample fresh mango juices, dried mango products, and traditional Egyptian sweets infused with mango flavors. The festival also includes cultural workshops on mango cultivation techniques and the fruit's significance in Egyptian agriculture.", 4, "Ismailia Mango Festival" },
                    { 32, "An internationally acclaimed film festival that transforms Alexandria into a cinematic hub, showcasing innovative short films from Egyptian and international filmmakers. The event features competitive screenings across multiple venues, masterclasses with renowned directors, industry networking sessions, and panel discussions on contemporary filmmaking techniques. Emerging filmmakers get the opportunity to present their work to industry professionals, critics, and cinema enthusiasts. The festival also includes workshops on digital filmmaking, script writing, and post-production techniques, making it a comprehensive learning experience for aspiring filmmakers.", 5, "Alexandria Short Film Festival" },
                    { 33, "A groundbreaking festival dedicated to celebrating women's contributions to theatre arts, featuring powerful performances by female playwrights, directors, and actresses from around the world. The festival presents thought-provoking plays addressing women's experiences, social issues, and contemporary challenges. Interactive workshops cover topics such as feminist theatre, directing techniques, and creative writing. Panel discussions bring together theatre professionals to explore gender representation in performing arts, while networking events connect women in theatre from different cultural backgrounds. The festival also includes community outreach programs promoting theatre education among young women.", 5, "International Women Theatre Festival" },
                    { 34, "A breathtaking astronomical phenomenon that occurs twice yearly when the rising sun perfectly aligns with the main axis of Karnak Temple, illuminating the sacred sanctuary in golden light. This ancient engineering marvel demonstrates the sophisticated astronomical knowledge of pharaonic architects who designed the temple to capture this celestial event. Visitors gather before dawn to witness this mystical moment, accompanied by expert Egyptologists who explain the religious and astronomical significance of the alignment. The event includes guided tours of the temple complex, lectures on ancient Egyptian astronomy, photography workshops, and cultural performances recreating ancient rituals that would have accompanied this sacred occurrence.", 2, "The Solar Alignment on the Karnak Temple" },
                    { 35, "The Arab world's most prestigious and longest-running film festival, transforming Cairo into the region's cinematic capital for two weeks each year. This internationally recognized event attracts A-list celebrities, renowned directors, producers, and film critics from around the globe. The festival screens hundreds of films across various categories including feature films, documentaries, and short films, with competitions for both regional and international productions. Red carpet galas, exclusive premieres, industry forums, and film market sessions provide networking opportunities for industry professionals. Educational programs include film workshops, master classes with acclaimed directors, and seminars on the future of Arab cinema.", 1, "Cairo International Film Festival" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EventTypeId", "Name" },
                values: new object[] { "A delightful celebration of Ismailia's world-renowned mangoes, featuring extensive agricultural exhibitions showcasing different mango varieties, traditional harvesting demonstrations, cooking competitions with mango-based dishes, live folk music performances, and family-friendly entertainment. Local farmers display their finest produce while visitors can sample fresh mango juices, dried mango products, and traditional Egyptian sweets infused with mango flavors. The festival also includes cultural workshops on mango cultivation techniques and the fruit's significance in Egyptian agriculture.", 4, "Ismailia Mango Festival" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EventTypeId", "Name" },
                values: new object[] { "An internationally acclaimed film festival that transforms Alexandria into a cinematic hub, showcasing innovative short films from Egyptian and international filmmakers. The event features competitive screenings across multiple venues, masterclasses with renowned directors, industry networking sessions, and panel discussions on contemporary filmmaking techniques. Emerging filmmakers get the opportunity to present their work to industry professionals, critics, and cinema enthusiasts. The festival also includes workshops on digital filmmaking, script writing, and post-production techniques, making it a comprehensive learning experience for aspiring filmmakers.", 5, "Alexandria Short Film Festival" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EventTypeId", "Name" },
                values: new object[] { "A groundbreaking festival dedicated to celebrating women's contributions to theatre arts, featuring powerful performances by female playwrights, directors, and actresses from around the world. The festival presents thought-provoking plays addressing women's experiences, social issues, and contemporary challenges. Interactive workshops cover topics such as feminist theatre, directing techniques, and creative writing. Panel discussions bring together theatre professionals to explore gender representation in performing arts, while networking events connect women in theatre from different cultural backgrounds. The festival also includes community outreach programs promoting theatre education among young women.", 5, "International Women Theatre Festival" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EventTypeId", "Name" },
                values: new object[] { "A breathtaking astronomical phenomenon that occurs twice yearly when the rising sun perfectly aligns with the main axis of Karnak Temple, illuminating the sacred sanctuary in golden light. This ancient engineering marvel demonstrates the sophisticated astronomical knowledge of pharaonic architects who designed the temple to capture this celestial event. Visitors gather before dawn to witness this mystical moment, accompanied by expert Egyptologists who explain the religious and astronomical significance of the alignment. The event includes guided tours of the temple complex, lectures on ancient Egyptian astronomy, photography workshops, and cultural performances recreating ancient rituals that would have accompanied this sacred occurrence.", 2, "The Solar Alignment on the Karnak Temple" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "EventTypeId", "Name" },
                values: new object[] { "The Arab world's most prestigious and longest-running film festival, transforming Cairo into the region's cinematic capital for two weeks each year. This internationally recognized event attracts A-list celebrities, renowned directors, producers, and film critics from around the globe. The festival screens hundreds of films across various categories including feature films, documentaries, and short films, with competitions for both regional and international productions. Red carpet galas, exclusive premieres, industry forums, and film market sessions provide networking opportunities for industry professionals. Educational programs include film workshops, master classes with acclaimed directors, and seminars on the future of Arab cinema.", 1, "Cairo International Film Festival" });
        }
    }
}
