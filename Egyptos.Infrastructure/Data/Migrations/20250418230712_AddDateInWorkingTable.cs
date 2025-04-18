using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDateInWorkingTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Workings",
                columns: new[] { "Id", "Day", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 1, "Saturday", new TimeOnly(20, 0, 0), new TimeOnly(12, 0, 0) },
                    { 2, "Sunday", new TimeOnly(20, 0, 0), new TimeOnly(8, 0, 0) },
                    { 3, "Monday", new TimeOnly(20, 0, 0), new TimeOnly(8, 0, 0) },
                    { 4, "Tuesday", new TimeOnly(20, 0, 0), new TimeOnly(8, 0, 0) },
                    { 5, "Wednesday", new TimeOnly(20, 0, 0), new TimeOnly(8, 0, 0) },
                    { 6, "Thursday", new TimeOnly(20, 0, 0), new TimeOnly(8, 0, 0) },
                    { 7, "Friday", new TimeOnly(20, 0, 0), new TimeOnly(13, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Workings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Workings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Workings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Workings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Workings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Workings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Workings",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
