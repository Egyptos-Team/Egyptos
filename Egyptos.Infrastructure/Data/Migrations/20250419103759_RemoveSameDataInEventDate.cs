using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSameDataInEventDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 25);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EventDates",
                columns: new[] { "Id", "Description", "EndDate", "EndSubscription", "EventId", "IsActiveToSubscribe", "Location", "Price", "StartDate", "StartSubscription" },
                values: new object[,]
                {
                    { 16, "​The Aswan International Cultural Festival is an annual event celebrating the rich heritage of Nubian culture through music, dance, and art.", new DateTime(2025, 2, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 30, 7, 50, 0, 0, DateTimeKind.Unspecified), 16, false, "Aswan, Egypt", 550.0, new DateTime(2025, 2, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 19, 7, 50, 0, 0, DateTimeKind.Unspecified) },
                    { 25, " This conference aims to explore various aspects of Islam and its cultural manifestations.​", new DateTime(2025, 11, 29, 10, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "Alexandria, Egypt", 250.0, new DateTime(2025, 11, 29, 1, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 20, 8, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
