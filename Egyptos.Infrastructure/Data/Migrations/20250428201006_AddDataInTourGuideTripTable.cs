using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataInTourGuideTripTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TourGuideTrips",
                columns: new[] { "TourGuideId", "TripId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 },
                    { 11, 11 },
                    { 13, 13 },
                    { 14, 14 },
                    { 15, 15 },
                    { 16, 16 },
                    { 17, 17 },
                    { 18, 18 },
                    { 19, 19 },
                    { 1, 20 },
                    { 2, 21 },
                    { 3, 22 },
                    { 4, 23 },
                    { 5, 24 },
                    { 6, 25 },
                    { 7, 26 },
                    { 8, 27 },
                    { 9, 28 },
                    { 10, 29 },
                    { 11, 30 },
                    { 12, 31 },
                    { 13, 32 },
                    { 14, 33 },
                    { 15, 34 },
                    { 16, 35 },
                    { 17, 36 },
                    { 18, 37 },
                    { 19, 38 },
                    { 1, 39 },
                    { 2, 40 },
                    { 3, 41 },
                    { 4, 42 },
                    { 5, 43 },
                    { 6, 44 },
                    { 7, 45 },
                    { 8, 46 },
                    { 9, 47 },
                    { 10, 48 },
                    { 11, 49 },
                    { 12, 50 },
                    { 13, 51 },
                    { 14, 52 },
                    { 15, 53 },
                    { 16, 54 },
                    { 17, 55 },
                    { 18, 56 },
                    { 19, 57 },
                    { 1, 58 },
                    { 2, 59 },
                    { 3, 60 },
                    { 4, 61 },
                    { 5, 62 },
                    { 6, 63 },
                    { 7, 64 },
                    { 8, 65 },
                    { 9, 66 },
                    { 10, 67 },
                    { 11, 68 },
                    { 12, 69 },
                    { 13, 70 },
                    { 14, 71 },
                    { 15, 72 },
                    { 16, 73 },
                    { 17, 74 },
                    { 18, 75 },
                    { 19, 76 },
                    { 1, 77 },
                    { 2, 78 },
                    { 5, 81 },
                    { 6, 82 },
                    { 7, 83 },
                    { 8, 84 },
                    { 9, 85 },
                    { 10, 86 },
                    { 11, 87 },
                    { 12, 88 },
                    { 13, 89 },
                    { 14, 90 },
                    { 15, 91 },
                    { 16, 92 },
                    { 17, 93 },
                    { 18, 94 },
                    { 19, 95 },
                    { 1, 96 },
                    { 2, 97 },
                    { 3, 98 },
                    { 4, 99 },
                    { 5, 100 },
                    { 6, 101 },
                    { 7, 102 },
                    { 8, 103 },
                    { 9, 104 },
                    { 10, 105 },
                    { 11, 106 },
                    { 12, 107 },
                    { 13, 108 },
                    { 14, 109 },
                    { 15, 110 },
                    { 16, 111 },
                    { 17, 112 },
                    { 18, 113 },
                    { 19, 114 },
                    { 1, 115 },
                    { 2, 116 },
                    { 3, 117 },
                    { 4, 118 },
                    { 5, 119 },
                    { 6, 120 },
                    { 7, 121 },
                    { 8, 122 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 13, 13 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 14, 14 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 15, 15 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 16, 16 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 17 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 18, 18 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 19, 19 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 2, 21 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 4, 23 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 5, 24 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 6, 25 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 7, 26 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 8, 27 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 9, 28 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 10, 29 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 11, 30 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 12, 31 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 13, 32 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 14, 33 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 15, 34 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 16, 35 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 36 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 18, 37 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 19, 38 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 39 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 2, 40 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 3, 41 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 4, 42 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 5, 43 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 6, 44 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 7, 45 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 8, 46 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 9, 47 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 10, 48 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 11, 49 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 12, 50 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 13, 51 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 14, 52 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 15, 53 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 16, 54 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 55 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 18, 56 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 19, 57 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 58 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 2, 59 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 3, 60 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 4, 61 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 5, 62 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 6, 63 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 7, 64 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 8, 65 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 9, 66 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 10, 67 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 11, 68 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 12, 69 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 13, 70 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 14, 71 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 15, 72 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 16, 73 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 74 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 18, 75 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 19, 76 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 77 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 2, 78 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 5, 81 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 6, 82 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 7, 83 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 8, 84 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 9, 85 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 10, 86 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 11, 87 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 12, 88 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 13, 89 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 14, 90 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 15, 91 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 16, 92 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 93 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 18, 94 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 19, 95 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 96 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 2, 97 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 3, 98 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 4, 99 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 5, 100 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 6, 101 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 7, 102 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 8, 103 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 9, 104 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 10, 105 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 11, 106 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 12, 107 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 13, 108 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 14, 109 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 15, 110 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 16, 111 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 112 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 18, 113 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 19, 114 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 115 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 2, 116 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 3, 117 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 4, 118 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 5, 119 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 6, 120 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 7, 121 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 8, 122 });
        }
    }
}
