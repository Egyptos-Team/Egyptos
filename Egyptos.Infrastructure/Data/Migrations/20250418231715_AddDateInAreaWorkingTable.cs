using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDateInAreaWorkingTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AreaWorkings",
                columns: new[] { "AreaId", "WorkingId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 7 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 3 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 3 },
                    { 7, 4 },
                    { 7, 5 },
                    { 7, 6 },
                    { 7, 7 },
                    { 8, 1 },
                    { 8, 2 },
                    { 8, 3 },
                    { 8, 4 },
                    { 8, 5 },
                    { 8, 6 },
                    { 8, 7 },
                    { 9, 1 },
                    { 9, 2 },
                    { 9, 3 },
                    { 9, 4 },
                    { 9, 5 },
                    { 9, 6 },
                    { 9, 7 },
                    { 10, 1 },
                    { 10, 2 },
                    { 10, 3 },
                    { 10, 4 },
                    { 10, 5 },
                    { 10, 6 },
                    { 10, 7 },
                    { 11, 1 },
                    { 11, 2 },
                    { 11, 3 },
                    { 11, 4 },
                    { 11, 5 },
                    { 11, 6 },
                    { 11, 7 },
                    { 12, 1 },
                    { 12, 2 },
                    { 12, 3 },
                    { 12, 4 },
                    { 12, 5 },
                    { 12, 6 },
                    { 12, 7 },
                    { 13, 1 },
                    { 13, 2 },
                    { 13, 3 },
                    { 13, 4 },
                    { 13, 5 },
                    { 13, 6 },
                    { 13, 7 },
                    { 14, 1 },
                    { 14, 2 },
                    { 14, 3 },
                    { 14, 4 },
                    { 14, 5 },
                    { 14, 6 },
                    { 14, 7 },
                    { 15, 1 },
                    { 15, 2 },
                    { 15, 3 },
                    { 15, 4 },
                    { 15, 5 },
                    { 15, 6 },
                    { 15, 7 },
                    { 16, 1 },
                    { 16, 2 },
                    { 16, 3 },
                    { 16, 4 },
                    { 16, 5 },
                    { 16, 6 },
                    { 16, 7 },
                    { 17, 1 },
                    { 17, 2 },
                    { 17, 3 },
                    { 17, 4 },
                    { 17, 5 },
                    { 17, 6 },
                    { 17, 7 },
                    { 18, 1 },
                    { 18, 2 },
                    { 18, 3 },
                    { 18, 4 },
                    { 18, 5 },
                    { 18, 6 },
                    { 18, 7 },
                    { 19, 1 },
                    { 19, 2 },
                    { 19, 3 },
                    { 19, 4 },
                    { 19, 5 },
                    { 19, 6 },
                    { 19, 7 },
                    { 20, 1 },
                    { 20, 2 },
                    { 20, 3 },
                    { 20, 4 },
                    { 20, 5 },
                    { 20, 6 },
                    { 20, 7 },
                    { 21, 1 },
                    { 21, 2 },
                    { 21, 3 },
                    { 21, 4 },
                    { 21, 5 },
                    { 21, 6 },
                    { 21, 7 },
                    { 22, 1 },
                    { 22, 2 },
                    { 22, 3 },
                    { 22, 4 },
                    { 22, 5 },
                    { 22, 6 },
                    { 22, 7 },
                    { 23, 1 },
                    { 23, 2 },
                    { 23, 3 },
                    { 23, 4 },
                    { 23, 5 },
                    { 23, 6 },
                    { 23, 7 },
                    { 24, 1 },
                    { 24, 2 },
                    { 24, 3 },
                    { 24, 4 },
                    { 24, 5 },
                    { 24, 6 },
                    { 24, 7 },
                    { 25, 1 },
                    { 25, 2 },
                    { 25, 3 },
                    { 25, 4 },
                    { 25, 5 },
                    { 25, 6 },
                    { 25, 7 },
                    { 26, 1 },
                    { 26, 2 },
                    { 26, 3 },
                    { 26, 4 },
                    { 26, 5 },
                    { 26, 6 },
                    { 26, 7 },
                    { 27, 1 },
                    { 27, 2 },
                    { 27, 3 },
                    { 27, 4 },
                    { 27, 5 },
                    { 27, 6 },
                    { 27, 7 },
                    { 28, 1 },
                    { 28, 2 },
                    { 28, 3 },
                    { 28, 4 },
                    { 28, 5 },
                    { 28, 6 },
                    { 28, 7 },
                    { 29, 1 },
                    { 29, 2 },
                    { 29, 3 },
                    { 29, 4 },
                    { 29, 5 },
                    { 29, 6 },
                    { 29, 7 },
                    { 30, 1 },
                    { 30, 2 },
                    { 30, 3 },
                    { 30, 4 },
                    { 30, 5 },
                    { 30, 6 },
                    { 30, 7 },
                    { 71, 1 },
                    { 71, 2 },
                    { 71, 3 },
                    { 71, 4 },
                    { 71, 5 },
                    { 71, 6 },
                    { 71, 7 },
                    { 72, 1 },
                    { 72, 2 },
                    { 72, 3 },
                    { 72, 4 },
                    { 72, 5 },
                    { 72, 6 },
                    { 72, 7 },
                    { 73, 1 },
                    { 73, 2 },
                    { 73, 3 },
                    { 73, 4 },
                    { 73, 5 },
                    { 73, 6 },
                    { 73, 7 },
                    { 74, 1 },
                    { 74, 2 },
                    { 74, 3 },
                    { 74, 4 },
                    { 74, 5 },
                    { 74, 6 },
                    { 74, 7 },
                    { 75, 1 },
                    { 75, 2 },
                    { 75, 3 },
                    { 75, 4 },
                    { 75, 5 },
                    { 75, 6 },
                    { 75, 7 },
                    { 76, 1 },
                    { 76, 2 },
                    { 76, 3 },
                    { 76, 4 },
                    { 76, 5 },
                    { 76, 6 },
                    { 76, 7 },
                    { 77, 1 },
                    { 77, 2 },
                    { 77, 3 },
                    { 77, 4 },
                    { 77, 5 },
                    { 77, 6 },
                    { 77, 7 },
                    { 78, 1 },
                    { 78, 2 },
                    { 78, 3 },
                    { 78, 4 },
                    { 78, 5 },
                    { 78, 6 },
                    { 78, 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 15, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 16, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 17, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 17, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 18, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 18, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 19, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 19, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 19, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 20, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 20, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 21, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 21, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 21, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 21, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 21, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 22, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 22, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 22, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 22, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 22, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 23, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 23, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 23, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 23, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 23, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 24, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 24, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 24, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 24, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 24, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 24, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 25, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 25, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 25, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 25, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 25, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 26, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 26, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 26, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 26, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 26, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 27, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 27, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 27, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 27, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 27, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 27, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 28, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 28, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 28, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 28, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 28, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 28, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 29, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 29, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 29, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 29, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 29, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 29, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 30, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 30, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 30, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 30, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 30, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 30, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 71, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 71, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 71, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 71, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 71, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 71, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 71, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 72, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 72, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 72, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 72, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 72, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 72, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 72, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 73, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 73, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 73, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 73, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 73, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 73, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 73, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 74, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 74, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 74, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 74, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 74, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 74, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 74, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 75, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 75, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 75, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 75, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 75, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 75, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 75, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 76, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 76, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 76, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 76, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 76, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 76, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 76, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 77, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 77, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 77, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 77, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 77, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 77, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 77, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 78, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 78, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 78, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 78, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 78, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 78, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 78, 7 });
        }
    }
}
