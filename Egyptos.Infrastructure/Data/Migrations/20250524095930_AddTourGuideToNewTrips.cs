using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTourGuideToNewTrips : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TourGuideTrips",
                columns: new[] { "TourGuideId", "TripId" },
                values: new object[,]
                {
                    { 7, 123 },
                    { 8, 124 },
                    { 9, 125 },
                    { 10, 126 },
                    { 11, 127 },
                    { 12, 128 },
                    { 13, 129 },
                    { 14, 130 },
                    { 15, 131 },
                    { 16, 132 },
                    { 17, 133 },
                    { 18, 134 },
                    { 19, 135 },
                    { 1, 136 },
                    { 2, 137 },
                    { 3, 138 },
                    { 4, 139 },
                    { 5, 140 },
                    { 6, 141 },
                    { 7, 142 },
                    { 8, 143 },
                    { 9, 144 },
                    { 10, 145 },
                    { 11, 146 },
                    { 12, 147 },
                    { 13, 148 },
                    { 14, 149 },
                    { 15, 150 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 7, 123 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 8, 124 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 9, 125 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 10, 126 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 11, 127 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 12, 128 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 13, 129 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 14, 130 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 15, 131 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 16, 132 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 133 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 18, 134 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 19, 135 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 136 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 2, 137 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 3, 138 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 4, 139 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 5, 140 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 6, 141 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 7, 142 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 8, 143 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 9, 144 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 10, 145 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 11, 146 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 12, 147 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 13, 148 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 14, 149 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 15, 150 });
        }
    }
}
