using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataInEventDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "EndSubscription", "StartDate", "StartSubscription" },
                values: new object[] { new DateTime(2025, 10, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 10, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "EndSubscription", "StartDate", "StartSubscription" },
                values: new object[] { new DateTime(2025, 11, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 23, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 8,
                column: "StartSubscription",
                value: new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 200.0);

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 550.0);

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "EndSubscription", "StartDate", "StartSubscription" },
                values: new object[] { new DateTime(2025, 11, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndDate", "EndSubscription", "StartDate", "StartSubscription" },
                values: new object[] { new DateTime(2026, 1, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndDate", "EndSubscription", "StartDate", "StartSubscription" },
                values: new object[] { new DateTime(2026, 4, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndDate", "EndSubscription", "StartDate", "StartSubscription" },
                values: new object[] { new DateTime(2026, 7, 21, 10, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 16, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 3, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndDate", "EndSubscription", "StartDate", "StartSubscription" },
                values: new object[] { new DateTime(2026, 2, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 25,
                column: "Price",
                value: 250.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "EndSubscription", "StartDate", "StartSubscription" },
                values: new object[] { new DateTime(2025, 4, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 10, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "EndSubscription", "StartDate", "StartSubscription" },
                values: new object[] { new DateTime(2025, 4, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 23, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 8,
                column: "StartSubscription",
                value: new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 500.0);

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "EndSubscription", "StartDate", "StartSubscription" },
                values: new object[] { new DateTime(2025, 7, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndDate", "EndSubscription", "StartDate", "StartSubscription" },
                values: new object[] { new DateTime(2025, 1, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndDate", "EndSubscription", "StartDate", "StartSubscription" },
                values: new object[] { new DateTime(2025, 4, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndDate", "EndSubscription", "StartDate", "StartSubscription" },
                values: new object[] { new DateTime(2025, 7, 21, 10, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 16, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 3, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndDate", "EndSubscription", "StartDate", "StartSubscription" },
                values: new object[] { new DateTime(2025, 2, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "EventDates",
                keyColumn: "Id",
                keyValue: 25,
                column: "Price",
                value: 200.0);
        }
    }
}
