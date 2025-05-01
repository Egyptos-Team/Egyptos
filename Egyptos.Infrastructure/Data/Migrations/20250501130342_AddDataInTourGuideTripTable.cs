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
            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsActiveToSubscribe",
                value: false);

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 12,
                column: "IsActiveToSubscribe",
                value: true);

            migrationBuilder.InsertData(
                table: "TourGuideTrips",
                columns: new[] { "TourGuideId", "TripId" },
                values: new object[,]
                {
                    { 5, 1 },
                    { 3, 2 },
                    { 1, 3 },
                    { 8, 4 },
                    { 7, 5 },
                    { 1, 6 },
                    { 9, 7 },
                    { 1, 8 },
                    { 2, 9 },
                    { 5, 10 },
                    { 2, 11 },
                    { 5, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 5, 15 },
                    { 1, 16 },
                    { 8, 17 },
                    { 6, 18 },
                    { 7, 19 },
                    { 3, 20 },
                    { 1, 21 },
                    { 9, 22 },
                    { 6, 23 },
                    { 7, 24 },
                    { 6, 25 },
                    { 5, 26 },
                    { 9, 27 },
                    { 1, 28 },
                    { 8, 29 },
                    { 1, 30 },
                    { 2, 31 },
                    { 1, 32 },
                    { 7, 33 },
                    { 5, 34 },
                    { 1, 35 },
                    { 5, 36 },
                    { 9, 37 },
                    { 6, 38 },
                    { 2, 39 },
                    { 3, 40 },
                    { 8, 41 },
                    { 3, 42 },
                    { 9, 43 },
                    { 5, 44 },
                    { 6, 45 },
                    { 6, 46 },
                    { 5, 47 },
                    { 5, 48 },
                    { 3, 49 },
                    { 2, 50 },
                    { 9, 51 },
                    { 3, 52 },
                    { 3, 53 },
                    { 7, 54 },
                    { 9, 55 },
                    { 3, 56 },
                    { 9, 57 },
                    { 3, 58 },
                    { 1, 59 },
                    { 1, 60 },
                    { 17, 61 },
                    { 17, 62 },
                    { 14, 63 },
                    { 16, 64 },
                    { 14, 65 },
                    { 14, 66 },
                    { 16, 67 },
                    { 13, 68 },
                    { 12, 69 },
                    { 16, 70 },
                    { 17, 71 },
                    { 15, 72 },
                    { 13, 73 },
                    { 14, 74 },
                    { 12, 75 },
                    { 13, 76 },
                    { 15, 77 },
                    { 17, 78 },
                    { 14, 81 },
                    { 17, 82 },
                    { 14, 83 },
                    { 13, 84 },
                    { 15, 85 },
                    { 12, 86 },
                    { 14, 87 },
                    { 14, 88 },
                    { 14, 89 },
                    { 17, 90 },
                    { 12, 91 },
                    { 13, 92 },
                    { 17, 93 },
                    { 13, 94 },
                    { 16, 95 },
                    { 12, 96 },
                    { 17, 97 },
                    { 12, 98 },
                    { 17, 99 },
                    { 17, 100 },
                    { 12, 101 },
                    { 12, 102 },
                    { 17, 103 },
                    { 15, 104 },
                    { 17, 105 },
                    { 15, 106 },
                    { 13, 107 },
                    { 16, 108 },
                    { 14, 109 },
                    { 15, 110 },
                    { 14, 111 },
                    { 12, 112 },
                    { 12, 113 },
                    { 15, 114 },
                    { 15, 115 },
                    { 16, 116 },
                    { 13, 117 },
                    { 15, 118 },
                    { 14, 119 },
                    { 17, 120 },
                    { 15, 121 },
                    { 15, 122 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 8, 17 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 6, 18 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 7, 19 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 3, 20 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 9, 22 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 6, 23 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 7, 24 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 6, 25 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 5, 26 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 9, 27 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 28 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 8, 29 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 30 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 2, 31 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 32 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 7, 33 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 5, 34 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 35 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 5, 36 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 9, 37 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 6, 38 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 2, 39 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 3, 40 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 8, 41 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 3, 42 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 9, 43 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 5, 44 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 6, 45 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 6, 46 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 5, 47 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 5, 48 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 3, 49 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 2, 50 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 9, 51 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 3, 52 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 3, 53 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 7, 54 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 9, 55 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 3, 56 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 9, 57 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 3, 58 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 59 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 1, 60 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 61 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 62 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 14, 63 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 16, 64 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 14, 65 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 14, 66 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 16, 67 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 13, 68 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 12, 69 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 16, 70 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 71 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 15, 72 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 13, 73 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 14, 74 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 12, 75 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 13, 76 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 15, 77 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 78 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 14, 81 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 82 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 14, 83 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 13, 84 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 15, 85 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 12, 86 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 14, 87 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 14, 88 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 14, 89 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 90 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 12, 91 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 13, 92 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 93 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 13, 94 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 16, 95 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 12, 96 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 97 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 12, 98 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 99 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 100 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 12, 101 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 12, 102 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 103 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 15, 104 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 105 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 15, 106 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 13, 107 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 16, 108 });

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
                keyValues: new object[] { 14, 111 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 12, 112 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 12, 113 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 15, 114 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 15, 115 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 16, 116 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 13, 117 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 15, 118 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 14, 119 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 17, 120 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 15, 121 });

            migrationBuilder.DeleteData(
                table: "TourGuideTrips",
                keyColumns: new[] { "TourGuideId", "TripId" },
                keyValues: new object[] { 15, 122 });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsActiveToSubscribe",
                value: true);

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 12,
                column: "IsActiveToSubscribe",
                value: false);
        }
    }
}
