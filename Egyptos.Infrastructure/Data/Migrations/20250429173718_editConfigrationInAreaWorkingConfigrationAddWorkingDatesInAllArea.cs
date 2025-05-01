using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class editConfigrationInAreaWorkingConfigrationAddWorkingDatesInAllArea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AreaWorkings",
                columns: new[] { "AreaId", "WorkingId" },
                values: new object[,]
                {
                    { 31, 1 },
                    { 31, 2 },
                    { 31, 3 },
                    { 31, 4 },
                    { 31, 5 },
                    { 31, 6 },
                    { 31, 7 },
                    { 32, 1 },
                    { 32, 2 },
                    { 32, 3 },
                    { 32, 4 },
                    { 32, 5 },
                    { 32, 6 },
                    { 32, 7 },
                    { 33, 1 },
                    { 33, 2 },
                    { 33, 3 },
                    { 33, 4 },
                    { 33, 5 },
                    { 33, 6 },
                    { 33, 7 },
                    { 34, 1 },
                    { 34, 2 },
                    { 34, 3 },
                    { 34, 4 },
                    { 34, 5 },
                    { 34, 6 },
                    { 34, 7 },
                    { 35, 1 },
                    { 35, 2 },
                    { 35, 3 },
                    { 35, 4 },
                    { 35, 5 },
                    { 35, 6 },
                    { 35, 7 },
                    { 36, 1 },
                    { 36, 2 },
                    { 36, 3 },
                    { 36, 4 },
                    { 36, 5 },
                    { 36, 6 },
                    { 36, 7 },
                    { 37, 1 },
                    { 37, 2 },
                    { 37, 3 },
                    { 37, 4 },
                    { 37, 5 },
                    { 37, 6 },
                    { 37, 7 },
                    { 38, 1 },
                    { 38, 2 },
                    { 38, 3 },
                    { 38, 4 },
                    { 38, 5 },
                    { 38, 6 },
                    { 38, 7 },
                    { 39, 1 },
                    { 39, 2 },
                    { 39, 3 },
                    { 39, 4 },
                    { 39, 5 },
                    { 39, 6 },
                    { 39, 7 },
                    { 40, 1 },
                    { 40, 2 },
                    { 40, 3 },
                    { 40, 4 },
                    { 40, 5 },
                    { 40, 6 },
                    { 40, 7 },
                    { 41, 1 },
                    { 41, 2 },
                    { 41, 3 },
                    { 41, 4 },
                    { 41, 5 },
                    { 41, 6 },
                    { 41, 7 },
                    { 42, 1 },
                    { 42, 2 },
                    { 42, 3 },
                    { 42, 4 },
                    { 42, 5 },
                    { 42, 6 },
                    { 42, 7 },
                    { 43, 1 },
                    { 43, 2 },
                    { 43, 3 },
                    { 43, 4 },
                    { 43, 5 },
                    { 43, 6 },
                    { 43, 7 },
                    { 44, 1 },
                    { 44, 2 },
                    { 44, 3 },
                    { 44, 4 },
                    { 44, 5 },
                    { 44, 6 },
                    { 44, 7 },
                    { 45, 1 },
                    { 45, 2 },
                    { 45, 3 },
                    { 45, 4 },
                    { 45, 5 },
                    { 45, 6 },
                    { 45, 7 },
                    { 46, 1 },
                    { 46, 2 },
                    { 46, 3 },
                    { 46, 4 },
                    { 46, 5 },
                    { 46, 6 },
                    { 46, 7 },
                    { 47, 1 },
                    { 47, 2 },
                    { 47, 3 },
                    { 47, 4 },
                    { 47, 5 },
                    { 47, 6 },
                    { 47, 7 },
                    { 48, 1 },
                    { 48, 2 },
                    { 48, 3 },
                    { 48, 4 },
                    { 48, 5 },
                    { 48, 6 },
                    { 48, 7 },
                    { 49, 1 },
                    { 49, 2 },
                    { 49, 3 },
                    { 49, 4 },
                    { 49, 5 },
                    { 49, 6 },
                    { 49, 7 },
                    { 50, 1 },
                    { 50, 2 },
                    { 50, 3 },
                    { 50, 4 },
                    { 50, 5 },
                    { 50, 6 },
                    { 50, 7 },
                    { 51, 1 },
                    { 51, 2 },
                    { 51, 3 },
                    { 51, 4 },
                    { 51, 5 },
                    { 51, 6 },
                    { 51, 7 },
                    { 52, 1 },
                    { 52, 2 },
                    { 52, 3 },
                    { 52, 4 },
                    { 52, 5 },
                    { 52, 6 },
                    { 52, 7 },
                    { 53, 1 },
                    { 53, 2 },
                    { 53, 3 },
                    { 53, 4 },
                    { 53, 5 },
                    { 53, 6 },
                    { 53, 7 },
                    { 54, 1 },
                    { 54, 2 },
                    { 54, 3 },
                    { 54, 4 },
                    { 54, 5 },
                    { 54, 6 },
                    { 54, 7 },
                    { 55, 1 },
                    { 55, 2 },
                    { 55, 3 },
                    { 55, 4 },
                    { 55, 5 },
                    { 55, 6 },
                    { 55, 7 },
                    { 56, 1 },
                    { 56, 2 },
                    { 56, 3 },
                    { 56, 4 },
                    { 56, 5 },
                    { 56, 6 },
                    { 56, 7 },
                    { 57, 1 },
                    { 57, 2 },
                    { 57, 3 },
                    { 57, 4 },
                    { 57, 5 },
                    { 57, 6 },
                    { 57, 7 },
                    { 58, 1 },
                    { 58, 2 },
                    { 58, 3 },
                    { 58, 4 },
                    { 58, 5 },
                    { 58, 6 },
                    { 58, 7 },
                    { 59, 1 },
                    { 59, 2 },
                    { 59, 3 },
                    { 59, 4 },
                    { 59, 5 },
                    { 59, 6 },
                    { 59, 7 },
                    { 60, 1 },
                    { 60, 2 },
                    { 60, 3 },
                    { 60, 4 },
                    { 60, 5 },
                    { 60, 6 },
                    { 60, 7 },
                    { 61, 1 },
                    { 61, 2 },
                    { 61, 3 },
                    { 61, 4 },
                    { 61, 5 },
                    { 61, 6 },
                    { 61, 7 },
                    { 62, 1 },
                    { 62, 2 },
                    { 62, 3 },
                    { 62, 4 },
                    { 62, 5 },
                    { 62, 6 },
                    { 62, 7 },
                    { 63, 1 },
                    { 63, 2 },
                    { 63, 3 },
                    { 63, 4 },
                    { 63, 5 },
                    { 63, 6 },
                    { 63, 7 },
                    { 64, 1 },
                    { 64, 2 },
                    { 64, 3 },
                    { 64, 4 },
                    { 64, 5 },
                    { 64, 6 },
                    { 64, 7 },
                    { 65, 1 },
                    { 65, 2 },
                    { 65, 3 },
                    { 65, 4 },
                    { 65, 5 },
                    { 65, 6 },
                    { 65, 7 },
                    { 66, 1 },
                    { 66, 2 },
                    { 66, 3 },
                    { 66, 4 },
                    { 66, 5 },
                    { 66, 6 },
                    { 66, 7 },
                    { 67, 1 },
                    { 67, 2 },
                    { 67, 3 },
                    { 67, 4 },
                    { 67, 5 },
                    { 67, 6 },
                    { 67, 7 },
                    { 68, 1 },
                    { 68, 2 },
                    { 68, 3 },
                    { 68, 4 },
                    { 68, 5 },
                    { 68, 6 },
                    { 68, 7 },
                    { 69, 1 },
                    { 69, 2 },
                    { 69, 3 },
                    { 69, 4 },
                    { 69, 5 },
                    { 69, 6 },
                    { 69, 7 },
                    { 70, 1 },
                    { 70, 2 },
                    { 70, 3 },
                    { 70, 4 },
                    { 70, 5 },
                    { 70, 6 },
                    { 70, 7 },
                    { 81, 1 },
                    { 81, 2 },
                    { 81, 3 },
                    { 81, 4 },
                    { 81, 5 },
                    { 81, 6 },
                    { 81, 7 },
                    { 82, 1 },
                    { 82, 2 },
                    { 82, 3 },
                    { 82, 4 },
                    { 82, 5 },
                    { 82, 6 },
                    { 82, 7 },
                    { 83, 1 },
                    { 83, 2 },
                    { 83, 3 },
                    { 83, 4 },
                    { 83, 5 },
                    { 83, 6 },
                    { 83, 7 },
                    { 84, 1 },
                    { 84, 2 },
                    { 84, 3 },
                    { 84, 4 },
                    { 84, 5 },
                    { 84, 6 },
                    { 84, 7 },
                    { 85, 1 },
                    { 85, 2 },
                    { 85, 3 },
                    { 85, 4 },
                    { 85, 5 },
                    { 85, 6 },
                    { 85, 7 },
                    { 86, 1 },
                    { 86, 2 },
                    { 86, 3 },
                    { 86, 4 },
                    { 86, 5 },
                    { 86, 6 },
                    { 86, 7 },
                    { 87, 1 },
                    { 87, 2 },
                    { 87, 3 },
                    { 87, 4 },
                    { 87, 5 },
                    { 87, 6 },
                    { 87, 7 },
                    { 88, 1 },
                    { 88, 2 },
                    { 88, 3 },
                    { 88, 4 },
                    { 88, 5 },
                    { 88, 6 },
                    { 88, 7 },
                    { 89, 1 },
                    { 89, 2 },
                    { 89, 3 },
                    { 89, 4 },
                    { 89, 5 },
                    { 89, 6 },
                    { 89, 7 },
                    { 90, 1 },
                    { 90, 2 },
                    { 90, 3 },
                    { 90, 4 },
                    { 90, 5 },
                    { 90, 6 },
                    { 90, 7 },
                    { 91, 1 },
                    { 91, 2 },
                    { 91, 3 },
                    { 91, 4 },
                    { 91, 5 },
                    { 91, 6 },
                    { 91, 7 },
                    { 92, 1 },
                    { 92, 2 },
                    { 92, 3 },
                    { 92, 4 },
                    { 92, 5 },
                    { 92, 6 },
                    { 92, 7 },
                    { 93, 1 },
                    { 93, 2 },
                    { 93, 3 },
                    { 93, 4 },
                    { 93, 5 },
                    { 93, 6 },
                    { 93, 7 },
                    { 94, 1 },
                    { 94, 2 },
                    { 94, 3 },
                    { 94, 4 },
                    { 94, 5 },
                    { 94, 6 },
                    { 94, 7 },
                    { 95, 1 },
                    { 95, 2 },
                    { 95, 3 },
                    { 95, 4 },
                    { 95, 5 },
                    { 95, 6 },
                    { 95, 7 },
                    { 96, 1 },
                    { 96, 2 },
                    { 96, 3 },
                    { 96, 4 },
                    { 96, 5 },
                    { 96, 6 },
                    { 96, 7 },
                    { 97, 1 },
                    { 97, 2 },
                    { 97, 3 },
                    { 97, 4 },
                    { 97, 5 },
                    { 97, 6 },
                    { 97, 7 },
                    { 98, 1 },
                    { 98, 2 },
                    { 98, 3 },
                    { 98, 4 },
                    { 98, 5 },
                    { 98, 6 },
                    { 98, 7 },
                    { 99, 1 },
                    { 99, 2 },
                    { 99, 3 },
                    { 99, 4 },
                    { 99, 5 },
                    { 99, 6 },
                    { 99, 7 },
                    { 100, 1 },
                    { 100, 2 },
                    { 100, 3 },
                    { 100, 4 },
                    { 100, 5 },
                    { 100, 6 },
                    { 100, 7 },
                    { 101, 1 },
                    { 101, 2 },
                    { 101, 3 },
                    { 101, 4 },
                    { 101, 5 },
                    { 101, 6 },
                    { 101, 7 },
                    { 102, 1 },
                    { 102, 2 },
                    { 102, 3 },
                    { 102, 4 },
                    { 102, 5 },
                    { 102, 6 },
                    { 102, 7 },
                    { 103, 1 },
                    { 103, 2 },
                    { 103, 3 },
                    { 103, 4 },
                    { 103, 5 },
                    { 103, 6 },
                    { 103, 7 },
                    { 104, 1 },
                    { 104, 2 },
                    { 104, 3 },
                    { 104, 4 },
                    { 104, 5 },
                    { 104, 6 },
                    { 104, 7 },
                    { 105, 1 },
                    { 105, 2 },
                    { 105, 3 },
                    { 105, 4 },
                    { 105, 5 },
                    { 105, 6 },
                    { 105, 7 },
                    { 106, 1 },
                    { 106, 2 },
                    { 106, 3 },
                    { 106, 4 },
                    { 106, 5 },
                    { 106, 6 },
                    { 106, 7 },
                    { 107, 1 },
                    { 107, 2 },
                    { 107, 3 },
                    { 107, 4 },
                    { 107, 5 },
                    { 107, 6 },
                    { 107, 7 },
                    { 108, 1 },
                    { 108, 2 },
                    { 108, 3 },
                    { 108, 4 },
                    { 108, 5 },
                    { 108, 6 },
                    { 108, 7 },
                    { 109, 1 },
                    { 109, 2 },
                    { 109, 3 },
                    { 109, 4 },
                    { 109, 5 },
                    { 109, 6 },
                    { 109, 7 },
                    { 110, 1 },
                    { 110, 2 },
                    { 110, 3 },
                    { 110, 4 },
                    { 110, 5 },
                    { 110, 6 },
                    { 110, 7 },
                    { 111, 1 },
                    { 111, 2 },
                    { 111, 3 },
                    { 111, 4 },
                    { 111, 5 },
                    { 111, 6 },
                    { 111, 7 },
                    { 112, 1 },
                    { 112, 2 },
                    { 112, 3 },
                    { 112, 4 },
                    { 112, 5 },
                    { 112, 6 },
                    { 112, 7 },
                    { 113, 1 },
                    { 113, 2 },
                    { 113, 3 },
                    { 113, 4 },
                    { 113, 5 },
                    { 113, 6 },
                    { 113, 7 },
                    { 114, 1 },
                    { 114, 2 },
                    { 114, 3 },
                    { 114, 4 },
                    { 114, 5 },
                    { 114, 6 },
                    { 114, 7 },
                    { 115, 1 },
                    { 115, 2 },
                    { 115, 3 },
                    { 115, 4 },
                    { 115, 5 },
                    { 115, 6 },
                    { 115, 7 },
                    { 116, 1 },
                    { 116, 2 },
                    { 116, 3 },
                    { 116, 4 },
                    { 116, 5 },
                    { 116, 6 },
                    { 116, 7 },
                    { 117, 1 },
                    { 117, 2 },
                    { 117, 3 },
                    { 117, 4 },
                    { 117, 5 },
                    { 117, 6 },
                    { 117, 7 },
                    { 118, 1 },
                    { 118, 2 },
                    { 118, 3 },
                    { 118, 4 },
                    { 118, 5 },
                    { 118, 6 },
                    { 118, 7 },
                    { 119, 1 },
                    { 119, 2 },
                    { 119, 3 },
                    { 119, 4 },
                    { 119, 5 },
                    { 119, 6 },
                    { 119, 7 },
                    { 120, 1 },
                    { 120, 2 },
                    { 120, 3 },
                    { 120, 4 },
                    { 120, 5 },
                    { 120, 6 },
                    { 120, 7 },
                    { 121, 1 },
                    { 121, 2 },
                    { 121, 3 },
                    { 121, 4 },
                    { 121, 5 },
                    { 121, 6 },
                    { 121, 7 },
                    { 122, 1 },
                    { 122, 2 },
                    { 122, 3 },
                    { 122, 4 },
                    { 122, 5 },
                    { 122, 6 },
                    { 122, 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 31, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 31, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 31, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 31, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 31, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 31, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 31, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 32, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 32, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 32, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 32, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 32, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 32, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 32, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 33, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 33, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 33, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 33, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 33, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 33, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 33, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 34, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 34, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 34, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 34, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 34, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 34, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 34, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 35, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 35, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 35, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 35, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 35, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 35, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 35, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 36, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 36, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 36, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 36, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 36, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 36, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 36, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 37, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 37, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 37, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 37, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 37, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 37, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 37, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 38, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 38, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 38, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 38, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 38, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 38, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 38, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 39, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 39, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 39, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 39, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 39, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 39, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 39, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 40, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 40, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 40, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 40, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 40, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 40, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 40, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 41, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 41, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 41, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 41, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 41, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 41, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 41, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 42, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 42, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 42, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 42, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 42, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 42, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 42, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 43, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 43, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 43, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 43, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 43, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 43, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 43, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 44, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 44, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 44, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 44, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 44, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 44, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 44, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 45, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 45, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 45, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 45, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 45, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 45, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 45, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 46, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 46, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 46, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 46, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 46, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 46, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 46, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 47, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 47, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 47, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 47, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 47, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 47, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 47, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 48, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 48, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 48, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 48, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 48, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 48, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 48, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 49, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 49, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 49, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 49, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 49, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 49, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 49, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 50, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 50, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 50, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 50, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 50, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 50, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 50, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 51, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 51, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 51, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 51, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 51, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 51, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 51, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 52, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 52, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 52, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 52, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 52, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 52, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 52, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 53, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 53, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 53, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 53, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 53, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 53, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 53, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 54, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 54, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 54, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 54, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 54, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 54, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 54, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 55, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 55, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 55, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 55, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 55, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 55, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 55, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 56, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 56, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 56, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 56, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 56, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 56, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 56, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 57, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 57, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 57, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 57, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 57, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 57, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 57, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 58, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 58, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 58, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 58, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 58, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 58, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 58, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 59, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 59, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 59, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 59, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 59, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 59, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 59, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 60, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 60, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 60, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 60, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 60, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 60, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 60, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 61, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 61, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 61, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 61, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 61, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 61, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 61, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 62, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 62, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 62, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 62, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 62, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 62, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 62, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 63, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 63, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 63, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 63, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 63, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 63, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 63, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 64, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 64, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 64, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 64, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 64, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 64, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 64, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 65, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 65, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 65, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 65, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 65, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 65, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 65, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 66, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 66, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 66, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 66, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 66, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 66, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 66, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 67, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 67, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 67, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 67, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 67, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 67, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 67, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 68, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 68, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 68, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 68, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 68, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 68, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 68, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 69, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 69, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 69, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 69, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 69, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 69, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 69, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 70, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 70, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 70, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 70, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 70, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 70, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 70, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 81, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 81, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 81, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 81, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 81, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 81, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 81, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 82, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 82, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 82, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 82, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 82, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 82, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 82, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 83, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 83, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 83, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 83, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 83, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 83, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 83, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 84, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 84, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 84, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 84, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 84, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 84, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 84, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 85, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 85, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 85, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 85, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 85, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 85, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 85, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 86, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 86, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 86, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 86, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 86, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 86, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 86, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 87, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 87, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 87, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 87, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 87, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 87, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 87, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 88, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 88, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 88, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 88, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 88, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 88, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 88, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 89, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 89, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 89, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 89, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 89, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 89, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 89, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 90, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 90, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 90, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 90, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 90, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 90, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 90, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 91, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 91, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 91, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 91, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 91, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 91, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 91, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 92, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 92, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 92, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 92, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 92, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 92, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 92, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 93, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 93, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 93, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 93, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 93, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 93, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 93, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 94, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 94, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 94, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 94, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 94, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 94, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 94, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 95, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 95, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 95, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 95, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 95, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 95, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 95, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 96, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 96, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 96, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 96, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 96, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 96, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 96, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 97, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 97, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 97, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 97, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 97, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 97, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 97, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 98, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 98, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 98, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 98, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 98, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 98, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 98, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 99, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 99, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 99, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 99, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 99, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 99, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 99, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 100, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 100, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 100, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 100, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 100, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 100, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 100, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 101, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 101, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 101, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 101, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 101, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 101, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 101, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 102, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 102, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 102, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 102, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 102, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 102, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 102, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 103, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 103, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 103, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 103, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 103, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 103, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 103, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 104, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 104, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 104, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 104, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 104, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 104, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 104, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 105, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 105, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 105, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 105, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 105, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 105, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 105, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 106, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 106, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 106, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 106, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 106, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 106, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 106, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 107, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 107, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 107, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 107, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 107, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 107, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 107, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 108, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 108, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 108, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 108, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 108, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 108, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 108, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 109, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 109, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 109, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 109, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 109, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 109, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 109, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 110, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 110, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 110, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 110, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 110, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 110, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 110, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 111, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 111, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 111, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 111, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 111, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 111, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 111, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 112, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 112, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 112, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 112, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 112, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 112, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 112, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 113, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 113, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 113, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 113, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 113, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 113, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 113, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 114, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 114, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 114, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 114, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 114, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 114, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 114, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 115, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 115, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 115, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 115, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 115, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 115, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 115, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 116, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 116, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 116, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 116, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 116, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 116, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 116, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 117, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 117, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 117, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 117, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 117, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 117, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 117, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 118, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 118, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 118, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 118, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 118, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 118, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 118, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 119, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 119, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 119, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 119, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 119, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 119, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 119, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 120, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 120, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 120, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 120, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 120, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 120, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 120, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 121, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 121, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 121, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 121, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 121, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 121, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 121, 7 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 122, 1 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 122, 2 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 122, 3 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 122, 4 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 122, 5 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 122, 6 });

            migrationBuilder.DeleteData(
                table: "AreaWorkings",
                keyColumns: new[] { "AreaId", "WorkingId" },
                keyValues: new object[] { 122, 7 });

            migrationBuilder.InsertData(
                table: "AreaWorkings",
                columns: new[] { "AreaId", "WorkingId" },
                values: new object[,]
                {
                    { 12, 1 },
                    { 12, 2 },
                    { 12, 3 },
                    { 12, 4 },
                    { 12, 5 },
                    { 12, 6 },
                    { 12, 7 }
                });
        }
    }
}
