using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTripPrograms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Areas_AreaId",
                table: "Trips");

            migrationBuilder.AlterColumn<int>(
                name: "AreaId",
                table: "Trips",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "TripProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TripId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripProgram_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "AreaId", "ArrivalTime", "AvailableSeats", "BackTime", "DepartureTime", "IsActive", "Price", "PublicTransportId" },
                values: new object[,]
                {
                    { 123, null, new DateTime(2025, 9, 12, 11, 45, 0, 0, DateTimeKind.Unspecified), 32, new DateTime(2025, 9, 12, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 12, 9, 30, 0, 0, DateTimeKind.Unspecified), true, 6850.0, 95 },
                    { 124, null, new DateTime(2025, 9, 14, 10, 55, 0, 0, DateTimeKind.Unspecified), 28, new DateTime(2025, 9, 14, 20, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 14, 8, 45, 0, 0, DateTimeKind.Unspecified), true, 7125.0, 95 },
                    { 125, null, new DateTime(2025, 9, 16, 12, 20, 0, 0, DateTimeKind.Unspecified), 35, new DateTime(2025, 9, 16, 22, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 16, 10, 15, 0, 0, DateTimeKind.Unspecified), true, 7450.0, 95 },
                    { 126, null, new DateTime(2025, 9, 18, 11, 10, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), true, 6975.0, 95 },
                    { 127, null, new DateTime(2025, 9, 20, 10, 35, 0, 0, DateTimeKind.Unspecified), 25, new DateTime(2025, 9, 20, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 20, 8, 30, 0, 0, DateTimeKind.Unspecified), true, 7200.0, 95 },
                    { 128, null, new DateTime(2025, 9, 22, 12, 50, 0, 0, DateTimeKind.Unspecified), 40, new DateTime(2025, 9, 22, 22, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 22, 10, 45, 0, 0, DateTimeKind.Unspecified), true, 7580.0, 95 },
                    { 129, null, new DateTime(2025, 9, 24, 11, 25, 0, 0, DateTimeKind.Unspecified), 33, new DateTime(2025, 9, 24, 21, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 24, 9, 15, 0, 0, DateTimeKind.Unspecified), true, 6800.0, 95 },
                    { 130, null, new DateTime(2025, 9, 26, 10, 15, 0, 0, DateTimeKind.Unspecified), 27, new DateTime(2025, 9, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 7350.0, 95 },
                    { 131, null, new DateTime(2025, 9, 28, 12, 40, 0, 0, DateTimeKind.Unspecified), 38, new DateTime(2025, 9, 28, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 28, 10, 30, 0, 0, DateTimeKind.Unspecified), true, 7680.0, 95 },
                    { 132, null, new DateTime(2025, 9, 30, 11, 50, 0, 0, DateTimeKind.Unspecified), 31, new DateTime(2025, 9, 30, 21, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 30, 9, 45, 0, 0, DateTimeKind.Unspecified), true, 7025.0, 95 },
                    { 133, null, new DateTime(2025, 10, 2, 10, 30, 0, 0, DateTimeKind.Unspecified), 29, new DateTime(2025, 10, 2, 20, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 2, 8, 15, 0, 0, DateTimeKind.Unspecified), true, 6900.0, 95 },
                    { 134, null, new DateTime(2025, 10, 4, 13, 5, 0, 0, DateTimeKind.Unspecified), 42, new DateTime(2025, 10, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), true, 7750.0, 95 },
                    { 135, null, new DateTime(2025, 10, 6, 11, 40, 0, 0, DateTimeKind.Unspecified), 26, new DateTime(2025, 10, 6, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 6, 9, 30, 0, 0, DateTimeKind.Unspecified), true, 7150.0, 95 },
                    { 136, null, new DateTime(2025, 10, 8, 10, 50, 0, 0, DateTimeKind.Unspecified), 36, new DateTime(2025, 10, 8, 20, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 8, 8, 45, 0, 0, DateTimeKind.Unspecified), true, 6750.0, 95 },
                    { 137, null, new DateTime(2025, 10, 10, 12, 25, 0, 0, DateTimeKind.Unspecified), 34, new DateTime(2025, 10, 10, 22, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 10, 10, 15, 0, 0, DateTimeKind.Unspecified), true, 7425.0, 95 },
                    { 138, null, new DateTime(2025, 10, 12, 11, 15, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 10, 12, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), true, 7080.0, 95 },
                    { 139, null, new DateTime(2025, 10, 14, 10, 40, 0, 0, DateTimeKind.Unspecified), 28, new DateTime(2025, 10, 14, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 14, 8, 30, 0, 0, DateTimeKind.Unspecified), true, 6850.0, 95 },
                    { 140, null, new DateTime(2025, 10, 16, 12, 55, 0, 0, DateTimeKind.Unspecified), 39, new DateTime(2025, 10, 16, 22, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 16, 10, 45, 0, 0, DateTimeKind.Unspecified), true, 7600.0, 95 },
                    { 141, null, new DateTime(2025, 10, 18, 11, 30, 0, 0, DateTimeKind.Unspecified), 32, new DateTime(2025, 10, 18, 21, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 18, 9, 15, 0, 0, DateTimeKind.Unspecified), true, 7250.0, 95 },
                    { 142, null, new DateTime(2025, 10, 20, 10, 10, 0, 0, DateTimeKind.Unspecified), 27, new DateTime(2025, 10, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 6925.0, 95 },
                    { 143, null, new DateTime(2025, 10, 22, 12, 35, 0, 0, DateTimeKind.Unspecified), 35, new DateTime(2025, 10, 22, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 22, 10, 30, 0, 0, DateTimeKind.Unspecified), true, 7475.0, 95 },
                    { 144, null, new DateTime(2025, 10, 24, 11, 55, 0, 0, DateTimeKind.Unspecified), 31, new DateTime(2025, 10, 24, 21, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 24, 9, 45, 0, 0, DateTimeKind.Unspecified), true, 7125.0, 95 },
                    { 145, null, new DateTime(2025, 10, 26, 10, 25, 0, 0, DateTimeKind.Unspecified), 29, new DateTime(2025, 10, 26, 20, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 26, 8, 15, 0, 0, DateTimeKind.Unspecified), true, 6800.0, 95 },
                    { 146, null, new DateTime(2025, 10, 28, 13, 10, 0, 0, DateTimeKind.Unspecified), 40, new DateTime(2025, 10, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), true, 7700.0, 95 },
                    { 147, null, new DateTime(2025, 10, 30, 11, 45, 0, 0, DateTimeKind.Unspecified), 33, new DateTime(2025, 10, 30, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 30, 9, 30, 0, 0, DateTimeKind.Unspecified), true, 7375.0, 95 },
                    { 148, null, new DateTime(2025, 11, 1, 10, 50, 0, 0, DateTimeKind.Unspecified), 28, new DateTime(2025, 11, 1, 20, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 1, 8, 45, 0, 0, DateTimeKind.Unspecified), true, 6950.0, 95 },
                    { 149, null, new DateTime(2025, 11, 3, 12, 20, 0, 0, DateTimeKind.Unspecified), 37, new DateTime(2025, 11, 3, 22, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 3, 10, 15, 0, 0, DateTimeKind.Unspecified), true, 7525.0, 95 },
                    { 150, null, new DateTime(2025, 11, 5, 11, 5, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 11, 5, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), true, 7200.0, 95 }
                });

            migrationBuilder.InsertData(
                table: "TripProgram",
                columns: new[] { "Id", "Description", "Destination", "EndDate", "StartDate", "TripId" },
                values: new object[,]
                {
                    { 1, "Eco-tourism and conservation awareness journey - Pharaonic jewelry crafting", "Tomb of the Aga Khan", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 123 },
                    { 2, "Desert survival and navigation experience - Monastery spiritual retreat", "Wadi El Natrun Monasteries", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 123 },
                    { 3, "Explore pristine coral reefs and marine life - Pottery making", "Nag Hammadi", new DateTime(2025, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 123 },
                    { 4, "Explore pristine coral reefs and marine life - Hieratic script learning", "Valley of the Queens", new DateTime(2025, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 124 },
                    { 5, "Spiritual pilgrimage through Christian Egypt - Religious manuscript study", "Wadi El Natrun Monasteries", new DateTime(2025, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 124 },
                    { 6, "Experience the solitude of desert monasticism - Nile wildlife safari", "Qena", new DateTime(2025, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 124 },
                    { 7, "Photography safari capturing Egypt's biodiversity - Royal mummy viewing", "Aswan Botanical Garden", new DateTime(2025, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 125 },
                    { 8, "Archaeological expedition with cutting-edge discoveries - Desert hermitage visit", "Nuweiba", new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 125 },
                    { 9, "Photography safari capturing Egypt's biodiversity - Nile wildlife safari", "Emerald Mines", new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 125 },
                    { 10, "Historical research expedition - Ancient art workshop", "Ramses III Temple", new DateTime(2025, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 126 },
                    { 11, "Historical research expedition - Meteorite site visit", "Baltim Beach", new DateTime(2025, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 126 },
                    { 12, "Photography safari capturing Egypt's biodiversity - Bird watching expedition", "Valley of the Whales", new DateTime(2025, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 126 },
                    { 13, "Experience the solitude of desert monasticism - Hieratic script learning", "Aswan Botanical Garden", new DateTime(2025, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 127 },
                    { 14, "Journey into the heart of pharaonic royalty - Marine sanctuary visit", "Cave of Swimmers", new DateTime(2025, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 127 },
                    { 15, "Experience the solitude of desert monasticism - Metalwork crafting", "Wadi Degla Protectorate", new DateTime(2025, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 127 },
                    { 16, "Navigate the sacred waters of the Nile Delta - Royal tomb exploration", "Mummification Museum", new DateTime(2025, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 128 },
                    { 17, "Journey into the heart of pharaonic royalty - Monastery spiritual retreat", "Blue Desert", new DateTime(2025, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 128 },
                    { 18, "Cultural exchange with Nubian communities - Glass blowing workshop", "Nag Hammadi", new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 128 },
                    { 19, "Cultural exchange with Nubian communities - Ancient art workshop", "Temple of Hatshepsut", new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 129 },
                    { 20, "Archaeological expedition with cutting-edge discoveries - Marine sanctuary visit", "Scetis Desert", new DateTime(2025, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 129 },
                    { 21, "Immerse in traditional Egyptian craftsmanship - Endemic species observation", "Qena", new DateTime(2025, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 129 },
                    { 22, "Immerse in traditional Egyptian craftsmanship - Hieratic script learning", "Fatimid Cemetery", new DateTime(2025, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 130 },
                    { 23, "Explore pristine coral reefs and marine life - Dolphin watching cruise", "English Mountain", new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 130 },
                    { 24, "Experience the solitude of desert monasticism - Endemic species observation", "Gebel Elba", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 130 },
                    { 25, "Uncover geological wonders of the Western Desert - Hieratic script learning", "Tombs of the Nobles", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 131 },
                    { 26, "Adventure through Egypt's untouched wilderness - Coptic art appreciation", "Taba Heights", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 131 },
                    { 27, "Archaeological expedition with cutting-edge discoveries - Endemic species observation", "Salt Lakes", new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 131 },
                    { 28, "Archaeological expedition with cutting-edge discoveries - Hieratic script learning", "Ramses III Temple", new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 132 },
                    { 29, "Immerse in traditional Egyptian craftsmanship - Deep sea fishing", "Saint Catherine's Protectorate", new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 132 },
                    { 30, "Adventure through Egypt's untouched wilderness - Traditional weaving", "Temple of Seti I at Kanais", new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 132 },
                    { 31, "Explore pristine coral reefs and marine life - Hieratic script learning", "Monastery of St. Simeon", new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 133 },
                    { 32, "Journey into the heart of pharaonic royalty - Fossil hunting", "Scetis Desert", new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 133 },
                    { 33, "Photography safari capturing Egypt's biodiversity - Bird watching expedition", "Wadi Degla Protectorate", new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 133 },
                    { 34, "Adventure through Egypt's untouched wilderness - Hieratic script learning", "Deir el-Bahari", new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 134 },
                    { 35, "Photography safari capturing Egypt's biodiversity - Marine sanctuary visit", "Baltim Beach", new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 134 },
                    { 36, "Experience the solitude of desert monasticism - Nile wildlife safari", "Dendera Archaeological Site", new DateTime(2025, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 134 },
                    { 37, "Explore pristine coral reefs and marine life - Hieratic script learning", "Aswan Botanical Garden", new DateTime(2025, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 135 },
                    { 38, "Marine biology adventure in protected waters - Red Sea coral diving", "Lake Burullus", new DateTime(2025, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 135 },
                    { 39, "Cultural exchange with Nubian communities - Traditional weaving", "Red Sea Mountains", new DateTime(2025, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 135 },
                    { 40, "Explore pristine coral reefs and marine life - Ancient art workshop", "Tombs of the Nobles", new DateTime(2025, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 136 },
                    { 41, "Experience the solitude of desert monasticism - Fossil hunting", "Wadi El Natrun Monasteries", new DateTime(2025, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 136 },
                    { 42, "Archaeological expedition with cutting-edge discoveries - Endemic species observation", "Petrified Forest", new DateTime(2025, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 136 },
                    { 43, "Experience the solitude of desert monasticism - Ancient art workshop", "Malkata Palace", new DateTime(2025, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 137 },
                    { 44, "Discover hidden treasures of ancient Egypt - Underwater cave exploration", "Baltim Beach", new DateTime(2025, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 137 },
                    { 45, "Cultural exchange with Nubian communities - Bird watching expedition", "Wadi Degla Protectorate", new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 137 },
                    { 46, "Discover hidden treasures of ancient Egypt - Hieratic script learning", "Monastery of St. Simeon", new DateTime(2025, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 138 },
                    { 47, "Photography safari capturing Egypt's biodiversity - Red Sea coral diving", "Ras El Bar", new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 138 },
                    { 48, "Journey into the heart of pharaonic royalty - Conservation project visit", "Valley of the Whales", new DateTime(2025, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 138 },
                    { 49, "Adventure through Egypt's untouched wilderness - Royal mummy viewing", "Kalabsha Temple", new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 139 },
                    { 50, "Journey into the heart of pharaonic royalty - Icon painting workshop", "Desert of the Fathers", new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 139 },
                    { 51, "Uncover geological wonders of the Western Desert - Metalwork crafting", "Emerald Mines", new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 139 },
                    { 52, "Discover hidden treasures of ancient Egypt - Royal mummy viewing", "Luxor Museum", new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 140 },
                    { 53, "Discover hidden treasures of ancient Egypt - Icon painting workshop", "Wadi El Natrun Monasteries", new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 140 },
                    { 54, "Explore pristine coral reefs and marine life - Traditional weaving", "Dendera Archaeological Site", new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 140 },
                    { 55, "Historical research expedition - Royal mummy viewing", "Luxor Museum", new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 141 },
                    { 56, "Discover hidden treasures of ancient Egypt - Religious manuscript study", "Crystal Mountain", new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 141 },
                    { 57, "Discover hidden treasures of ancient Egypt - Metalwork crafting", "Gebel Elba", new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 141 },
                    { 58, "Archaeological expedition with cutting-edge discoveries - Royal tomb exploration", "Tombs of the Nobles", new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 142 },
                    { 59, "Journey into the heart of pharaonic royalty - Desert hermitage visit", "Ras El Bar", new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 142 },
                    { 60, "Historical research expedition - Conservation project visit", "Salt Lakes", new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 142 },
                    { 61, "Photography safari capturing Egypt's biodiversity - Pharaonic jewelry crafting", "Tomb of the Aga Khan", new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 143 },
                    { 62, "Adventure through Egypt's untouched wilderness - Desert hermitage visit", "Ras El Bar", new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 143 },
                    { 63, "Eco-tourism and conservation awareness journey - Endemic species observation", "Red Sea Mountains", new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 143 },
                    { 64, "Photography safari capturing Egypt's biodiversity - Pharaonic jewelry crafting", "Tomb of the Aga Khan", new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 144 },
                    { 65, "Cultural exchange with Nubian communities - Geological survey", "Damietta", new DateTime(2025, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 144 },
                    { 66, "Experience the solitude of desert monasticism - Bird watching expedition", "Qena", new DateTime(2025, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 144 },
                    { 67, "Experience the solitude of desert monasticism - Hieratic script learning", "Temple of Hatshepsut", new DateTime(2025, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 145 },
                    { 68, "Uncover geological wonders of the Western Desert - Red Sea coral diving", "Blue Desert", new DateTime(2025, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 145 },
                    { 69, "Navigate the sacred waters of the Nile Delta - Conservation project visit", "Gebel Elba", new DateTime(2025, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 145 },
                    { 70, "Immerse in traditional Egyptian craftsmanship - Royal tomb exploration", "Malkata Palace", new DateTime(2025, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 146 },
                    { 71, "Archaeological expedition with cutting-edge discoveries - Marine sanctuary visit", "Lake Burullus", new DateTime(2025, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 146 },
                    { 72, "Spiritual pilgrimage through Christian Egypt - Metalwork crafting", "Qena", new DateTime(2025, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 146 },
                    { 73, "Navigate the sacred waters of the Nile Delta - Ancient art workshop", "Amenhotep III Temple", new DateTime(2025, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 147 },
                    { 74, "Experience the solitude of desert monasticism - Ancient lake exploration", "English Mountain", new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 147 },
                    { 75, "Experience the solitude of desert monasticism - Metalwork crafting", "Temple of Seti I at Kanais", new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 147 },
                    { 76, "Experience the solitude of desert monasticism - Royal tomb exploration", "Luxor Museum", new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 148 },
                    { 77, "Spiritual pilgrimage through Christian Egypt - Coptic art appreciation", "Monastery of Saint Macarius", new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 148 },
                    { 78, "Archaeological expedition with cutting-edge discoveries - Pottery making", "Emerald Mines", new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 148 },
                    { 79, "Archaeological expedition with cutting-edge discoveries - Hieratic script learning", "Fatimid Cemetery", new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 149 },
                    { 80, "Photography safari capturing Egypt's biodiversity - Marine sanctuary visit", "Lake Burullus", new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 149 },
                    { 81, "Desert survival and navigation experience - Glass blowing workshop", "Dendera Archaeological Site", new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 149 },
                    { 82, "Cultural exchange with Nubian communities - Royal mummy viewing", "Deir el-Bahari", new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { 83, "Immerse in traditional Egyptian craftsmanship - Meteorite site visit", "Black Desert", new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { 84, "Archaeological expedition with cutting-edge discoveries - Conservation project visit", "Qena", new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 150 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TripProgram_TripId",
                table: "TripProgram",
                column: "TripId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Areas_AreaId",
                table: "Trips",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Areas_AreaId",
                table: "Trips");

            migrationBuilder.DropTable(
                name: "TripProgram");

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.AlterColumn<int>(
                name: "AreaId",
                table: "Trips",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Areas_AreaId",
                table: "Trips",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
