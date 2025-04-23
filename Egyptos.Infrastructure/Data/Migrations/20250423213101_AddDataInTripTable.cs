using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataInTripTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "AreaId", "ArrivalTime", "AvailableSeats", "BackTime", "DepartureTime", "IsActive", "Price", "PublicTransportId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 7, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 1000.0, 1 },
                    { 2, 2, new DateTime(2025, 7, 11, 13, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 11, 11, 30, 0, 0, DateTimeKind.Unspecified), true, 1100.0, 2 },
                    { 3, 3, new DateTime(2025, 7, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), true, 1200.0, 3 },
                    { 4, 4, new DateTime(2025, 7, 13, 17, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 13, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 15, 30, 0, 0, DateTimeKind.Unspecified), true, 1300.0, 4 },
                    { 5, 5, new DateTime(2025, 7, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), true, 1400.0, 5 },
                    { 6, 6, new DateTime(2025, 7, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 1500.0, 6 },
                    { 7, 7, new DateTime(2025, 7, 16, 13, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 16, 11, 30, 0, 0, DateTimeKind.Unspecified), true, 1600.0, 7 },
                    { 8, 8, new DateTime(2025, 7, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 17, 14, 0, 0, 0, DateTimeKind.Unspecified), true, 1700.0, 8 },
                    { 9, 9, new DateTime(2025, 7, 18, 17, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 18, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 18, 15, 30, 0, 0, DateTimeKind.Unspecified), true, 1800.0, 9 },
                    { 10, 10, new DateTime(2025, 7, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), true, 1900.0, 10 },
                    { 11, 11, new DateTime(2025, 7, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 2000.0, 11 },
                    { 12, 11, new DateTime(2025, 7, 21, 13, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 21, 11, 30, 0, 0, DateTimeKind.Unspecified), true, 2100.0, 12 },
                    { 13, 13, new DateTime(2025, 7, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), true, 2200.0, 13 },
                    { 14, 14, new DateTime(2025, 7, 23, 17, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 23, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 23, 15, 30, 0, 0, DateTimeKind.Unspecified), true, 2300.0, 14 },
                    { 15, 15, new DateTime(2025, 7, 24, 18, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), true, 2400.0, 15 },
                    { 16, 16, new DateTime(2025, 7, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 2500.0, 16 },
                    { 17, 17, new DateTime(2025, 7, 26, 13, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 26, 11, 30, 0, 0, DateTimeKind.Unspecified), true, 2600.0, 17 },
                    { 18, 18, new DateTime(2025, 7, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), true, 2700.0, 18 },
                    { 19, 19, new DateTime(2025, 7, 28, 17, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 28, 15, 30, 0, 0, DateTimeKind.Unspecified), true, 2800.0, 19 },
                    { 20, 20, new DateTime(2025, 7, 29, 18, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), true, 2900.0, 20 },
                    { 21, 21, new DateTime(2025, 7, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 7, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 3000.0, 21 },
                    { 22, 22, new DateTime(2025, 8, 1, 13, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 1, 11, 30, 0, 0, DateTimeKind.Unspecified), true, 3100.0, 22 },
                    { 23, 23, new DateTime(2025, 8, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 2, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), true, 3200.0, 23 },
                    { 24, 24, new DateTime(2025, 8, 3, 17, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 3, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 3, 15, 30, 0, 0, DateTimeKind.Unspecified), true, 3300.0, 24 },
                    { 25, 25, new DateTime(2025, 8, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), true, 3400.0, 25 },
                    { 26, 26, new DateTime(2025, 8, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 3500.0, 26 },
                    { 27, 27, new DateTime(2025, 8, 6, 13, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 6, 11, 30, 0, 0, DateTimeKind.Unspecified), true, 3600.0, 27 },
                    { 28, 28, new DateTime(2025, 8, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), true, 3700.0, 28 },
                    { 29, 29, new DateTime(2025, 8, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 8, 15, 30, 0, 0, DateTimeKind.Unspecified), true, 3800.0, 29 },
                    { 30, 30, new DateTime(2025, 8, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), true, 3900.0, 30 },
                    { 31, 31, new DateTime(2025, 8, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 4000.0, 31 },
                    { 32, 32, new DateTime(2025, 8, 11, 13, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 11, 11, 30, 0, 0, DateTimeKind.Unspecified), true, 4100.0, 32 },
                    { 33, 33, new DateTime(2025, 8, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), true, 4200.0, 33 },
                    { 34, 34, new DateTime(2025, 8, 13, 17, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 13, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 13, 15, 30, 0, 0, DateTimeKind.Unspecified), true, 4300.0, 34 },
                    { 35, 35, new DateTime(2025, 8, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), true, 4400.0, 35 },
                    { 36, 36, new DateTime(2025, 8, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 4500.0, 36 },
                    { 37, 37, new DateTime(2025, 8, 16, 13, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 16, 11, 30, 0, 0, DateTimeKind.Unspecified), true, 4600.0, 37 },
                    { 38, 38, new DateTime(2025, 8, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 17, 14, 0, 0, 0, DateTimeKind.Unspecified), true, 4700.0, 38 },
                    { 39, 39, new DateTime(2025, 8, 18, 17, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 18, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 18, 15, 30, 0, 0, DateTimeKind.Unspecified), true, 4800.0, 39 },
                    { 40, 40, new DateTime(2025, 8, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), true, 4900.0, 40 },
                    { 41, 41, new DateTime(2025, 8, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 5000.0, 41 },
                    { 42, 42, new DateTime(2025, 8, 21, 13, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 21, 11, 30, 0, 0, DateTimeKind.Unspecified), true, 5100.0, 42 },
                    { 43, 43, new DateTime(2025, 8, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), true, 5200.0, 43 },
                    { 44, 44, new DateTime(2025, 8, 23, 17, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 23, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 23, 15, 30, 0, 0, DateTimeKind.Unspecified), true, 5300.0, 44 },
                    { 45, 45, new DateTime(2025, 8, 24, 18, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), true, 5400.0, 45 },
                    { 46, 46, new DateTime(2025, 8, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 5500.0, 46 },
                    { 47, 47, new DateTime(2025, 8, 26, 13, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 26, 11, 30, 0, 0, DateTimeKind.Unspecified), true, 5600.0, 47 },
                    { 48, 48, new DateTime(2025, 8, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), true, 5700.0, 48 },
                    { 49, 49, new DateTime(2025, 8, 28, 17, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 28, 15, 30, 0, 0, DateTimeKind.Unspecified), true, 5800.0, 49 },
                    { 50, 50, new DateTime(2025, 8, 29, 18, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), true, 5900.0, 50 },
                    { 51, 51, new DateTime(2025, 8, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 6000.0, 51 },
                    { 52, 52, new DateTime(2025, 9, 1, 13, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 1, 11, 30, 0, 0, DateTimeKind.Unspecified), true, 6100.0, 52 },
                    { 53, 53, new DateTime(2025, 9, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 2, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), true, 6200.0, 53 },
                    { 54, 54, new DateTime(2025, 9, 3, 17, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 3, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 3, 15, 30, 0, 0, DateTimeKind.Unspecified), true, 6300.0, 54 },
                    { 55, 55, new DateTime(2025, 9, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), true, 6400.0, 55 },
                    { 56, 56, new DateTime(2025, 9, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 6500.0, 56 },
                    { 57, 57, new DateTime(2025, 9, 6, 13, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 6, 11, 30, 0, 0, DateTimeKind.Unspecified), true, 6600.0, 57 },
                    { 58, 58, new DateTime(2025, 9, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), true, 6700.0, 58 },
                    { 59, 59, new DateTime(2025, 9, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 8, 15, 30, 0, 0, DateTimeKind.Unspecified), true, 6800.0, 59 },
                    { 60, 60, new DateTime(2025, 9, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), true, 6900.0, 60 },
                    { 61, 61, new DateTime(2025, 9, 12, 10, 33, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 12, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 7392.0, 61 },
                    { 62, 62, new DateTime(2025, 9, 10, 11, 24, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 10, 19, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 6803.0, 62 },
                    { 63, 63, new DateTime(2025, 9, 12, 14, 8, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 12, 23, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), true, 7165.0, 63 },
                    { 64, 64, new DateTime(2025, 9, 12, 11, 58, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 12, 19, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), true, 6710.0, 64 },
                    { 65, 65, new DateTime(2025, 9, 11, 12, 31, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 11, 18, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 7219.0, 65 },
                    { 66, 66, new DateTime(2025, 9, 12, 13, 47, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 12, 19, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), true, 7091.0, 66 },
                    { 67, 67, new DateTime(2025, 9, 13, 14, 17, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 13, 23, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), true, 6882.0, 67 },
                    { 68, 68, new DateTime(2025, 9, 11, 10, 27, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 11, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 6827.0, 68 },
                    { 69, 69, new DateTime(2025, 9, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 10, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 6812.0, 69 },
                    { 70, 70, new DateTime(2025, 9, 11, 10, 54, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 11, 17, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 6833.0, 70 },
                    { 71, 71, new DateTime(2025, 9, 10, 13, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 10, 19, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 7343.0, 71 },
                    { 72, 72, new DateTime(2025, 9, 10, 12, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 10, 20, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), true, 6912.0, 72 },
                    { 73, 73, new DateTime(2025, 9, 13, 12, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 13, 22, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 7140.0, 73 },
                    { 74, 74, new DateTime(2025, 9, 13, 12, 5, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 13, 21, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), true, 7012.0, 74 },
                    { 75, 75, new DateTime(2025, 9, 13, 11, 11, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 13, 21, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), true, 6931.0, 75 },
                    { 76, 76, new DateTime(2025, 9, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 11, 17, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 6876.0, 76 },
                    { 77, 77, new DateTime(2025, 9, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 11, 21, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 7234.0, 77 },
                    { 78, 78, new DateTime(2025, 9, 12, 14, 13, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 12, 23, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), true, 7163.0, 78 },
                    { 81, 81, new DateTime(2025, 9, 10, 12, 7, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 10, 19, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), true, 6965.0, 81 },
                    { 82, 82, new DateTime(2025, 9, 10, 13, 52, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 10, 19, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), true, 6744.0, 82 },
                    { 83, 83, new DateTime(2025, 9, 12, 10, 9, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 12, 20, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 6950.0, 83 },
                    { 84, 84, new DateTime(2025, 9, 10, 12, 8, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 10, 17, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), true, 7366.0, 84 },
                    { 85, 85, new DateTime(2025, 9, 10, 10, 29, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 10, 20, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 7109.0, 85 },
                    { 86, 86, new DateTime(2025, 9, 13, 10, 57, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 13, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 7193.0, 86 },
                    { 87, 87, new DateTime(2025, 9, 11, 13, 31, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 11, 19, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), true, 6932.0, 87 },
                    { 88, 88, new DateTime(2025, 9, 13, 13, 45, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 13, 19, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), true, 7242.0, 88 },
                    { 89, 89, new DateTime(2025, 9, 12, 11, 38, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 12, 17, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), true, 6967.0, 89 },
                    { 90, 90, new DateTime(2025, 9, 11, 14, 12, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 11, 19, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), true, 7114.0, 90 },
                    { 91, 91, new DateTime(2025, 9, 11, 12, 37, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 11, 20, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 7236.0, 91 },
                    { 92, 92, new DateTime(2025, 9, 13, 12, 54, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 13, 22, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 6739.0, 92 },
                    { 93, 93, new DateTime(2025, 9, 10, 11, 19, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 10, 17, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 6953.0, 93 },
                    { 94, 94, new DateTime(2025, 9, 12, 12, 23, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 12, 18, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 6817.0, 94 },
                    { 95, 95, new DateTime(2025, 9, 13, 10, 41, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 13, 19, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 6783.0, 95 },
                    { 96, 96, new DateTime(2025, 9, 12, 13, 31, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 12, 23, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), true, 7277.0, 96 },
                    { 97, 97, new DateTime(2025, 9, 10, 13, 1, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 10, 21, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 7315.0, 97 },
                    { 98, 98, new DateTime(2025, 9, 10, 12, 7, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 10, 20, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), true, 6833.0, 98 },
                    { 99, 99, new DateTime(2025, 9, 12, 12, 10, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 12, 18, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 6802.0, 99 },
                    { 100, 100, new DateTime(2025, 9, 13, 14, 10, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 13, 22, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), true, 7249.0, 100 },
                    { 101, 101, new DateTime(2025, 9, 12, 10, 53, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 12, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 6728.0, 101 },
                    { 102, 102, new DateTime(2025, 9, 10, 11, 7, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 10, 16, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 7270.0, 102 },
                    { 103, 103, new DateTime(2025, 9, 11, 13, 44, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 11, 20, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), true, 6938.0, 103 },
                    { 104, 104, new DateTime(2025, 9, 12, 10, 14, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 12, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 7044.0, 104 },
                    { 105, 105, new DateTime(2025, 9, 10, 10, 16, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 10, 19, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 7075.0, 105 },
                    { 106, 106, new DateTime(2025, 9, 10, 10, 44, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 10, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 6846.0, 106 },
                    { 107, 107, new DateTime(2025, 9, 13, 12, 32, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 13, 21, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 6942.0, 107 },
                    { 108, 108, new DateTime(2025, 9, 12, 11, 4, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 12, 19, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 6825.0, 108 },
                    { 109, 109, new DateTime(2025, 9, 10, 13, 14, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 10, 22, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), true, 7046.0, 109 },
                    { 110, 110, new DateTime(2025, 9, 10, 14, 21, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 10, 22, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), true, 6862.0, 110 },
                    { 111, 111, new DateTime(2025, 9, 11, 13, 11, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 11, 18, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 7111.0, 111 },
                    { 112, 112, new DateTime(2025, 9, 13, 11, 36, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 13, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), true, 6876.0, 112 },
                    { 113, 113, new DateTime(2025, 9, 10, 13, 49, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 10, 21, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), true, 7315.0, 113 },
                    { 114, 114, new DateTime(2025, 9, 12, 12, 15, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 12, 20, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), true, 7214.0, 114 },
                    { 115, 115, new DateTime(2025, 9, 10, 12, 30, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 10, 18, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 6940.0, 115 },
                    { 116, 116, new DateTime(2025, 9, 12, 13, 21, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 12, 21, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), true, 7192.0, 116 },
                    { 117, 117, new DateTime(2025, 9, 11, 11, 2, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 11, 20, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, 7155.0, 117 },
                    { 118, 118, new DateTime(2025, 9, 13, 12, 6, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 13, 19, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), true, 6988.0, 118 },
                    { 119, 119, new DateTime(2025, 9, 11, 13, 10, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 11, 18, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 7329.0, 119 },
                    { 120, 120, new DateTime(2025, 9, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 12, 18, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 7358.0, 120 },
                    { 121, 121, new DateTime(2025, 9, 12, 12, 12, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 12, 20, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 6851.0, 121 },
                    { 122, 122, new DateTime(2025, 9, 10, 12, 4, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2025, 9, 10, 22, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), true, 7308.0, 122 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 122);
        }
    }
}
