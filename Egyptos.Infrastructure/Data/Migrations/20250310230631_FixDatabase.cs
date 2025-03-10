using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "AreaImages");

            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "TourGuides",
                newName: "SalaryPerHour");

            migrationBuilder.RenameColumn(
                name: "PricePerHoure",
                table: "PrivateTransport",
                newName: "PricePerHour");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TourGuides",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Rate",
                table: "TourGuides",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "YearsOfExperience",
                table: "TourGuides",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Report",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "PricePerHour",
                table: "Hotels",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PaymentCancel",
                table: "BookingPrivateTransport",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PaymentDate",
                table: "BookingPrivateTransport",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckIn",
                table: "BookingHotels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckOut",
                table: "BookingHotels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "TotalPrice",
                table: "BookingHotels",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Areas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "EventImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventImages_EventDates_EventId",
                        column: x => x.EventId,
                        principalTable: "EventDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Workings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AreaWorkings",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    WorkingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaWorkings", x => new { x.AreaId, x.WorkingId });
                    table.ForeignKey(
                        name: "FK_AreaWorkings_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreaWorkings_Workings_WorkingId",
                        column: x => x.WorkingId,
                        principalTable: "Workings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4b2f91d-9e12-4f4a-b3db-1b58fca15e66",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDg5wB8B7TZOHnMRerd9odJTwdNSiW3g+yN9x/Tv+9qGpaSdoV1N0wddxNjQMQz7HQ==");

            migrationBuilder.CreateIndex(
                name: "IX_AreaWorkings_WorkingId",
                table: "AreaWorkings",
                column: "WorkingId");

            migrationBuilder.CreateIndex(
                name: "IX_EventImages_EventId",
                table: "EventImages",
                column: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaWorkings");

            migrationBuilder.DropTable(
                name: "EventImages");

            migrationBuilder.DropTable(
                name: "Workings");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TourGuides");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "TourGuides");

            migrationBuilder.DropColumn(
                name: "YearsOfExperience",
                table: "TourGuides");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "PricePerHour",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "PaymentCancel",
                table: "BookingPrivateTransport");

            migrationBuilder.DropColumn(
                name: "PaymentDate",
                table: "BookingPrivateTransport");

            migrationBuilder.DropColumn(
                name: "CheckIn",
                table: "BookingHotels");

            migrationBuilder.DropColumn(
                name: "CheckOut",
                table: "BookingHotels");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "BookingHotels");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Areas");

            migrationBuilder.RenameColumn(
                name: "SalaryPerHour",
                table: "TourGuides",
                newName: "Salary");

            migrationBuilder.RenameColumn(
                name: "PricePerHour",
                table: "PrivateTransport",
                newName: "PricePerHoure");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Report",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AreaImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4b2f91d-9e12-4f4a-b3db-1b58fca15e66",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAAQfsJAZaLbizZifT7mdqD9BsRN5RjBBBCQSR/G9ehZVfEFkh9EEk5w+dlyP15Nvw==");
        }
    }
}
