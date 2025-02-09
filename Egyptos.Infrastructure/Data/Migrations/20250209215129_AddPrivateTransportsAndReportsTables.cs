using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPrivateTransportsAndReportsTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingEventDate_AspNetUsers_UserId",
                table: "BookingEventDate");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingEventDate_EventDate_EventDateId",
                table: "BookingEventDate");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_EventType_EventTypeId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_EventDate_Event_EventId",
                table: "EventDate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventType",
                table: "EventType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventDate",
                table: "EventDate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Event",
                table: "Event");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingEventDate",
                table: "BookingEventDate");

            migrationBuilder.RenameTable(
                name: "EventType",
                newName: "EventTypes");

            migrationBuilder.RenameTable(
                name: "EventDate",
                newName: "EventDates");

            migrationBuilder.RenameTable(
                name: "Event",
                newName: "Events");

            migrationBuilder.RenameTable(
                name: "BookingEventDate",
                newName: "BookingEventDates");

            migrationBuilder.RenameIndex(
                name: "IX_EventDate_EventId",
                table: "EventDates",
                newName: "IX_EventDates_EventId");

            migrationBuilder.RenameIndex(
                name: "IX_Event_EventTypeId",
                table: "Events",
                newName: "IX_Events_EventTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_BookingEventDate_EventDateId",
                table: "BookingEventDates",
                newName: "IX_BookingEventDates_EventDateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventTypes",
                table: "EventTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventDates",
                table: "EventDates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingEventDates",
                table: "BookingEventDates",
                columns: new[] { "UserId", "EventDateId" });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Report_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransportType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrivateTransport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PricePerHoure = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TransportTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateTransport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrivateTransport_TransportType_TransportTypeId",
                        column: x => x.TransportTypeId,
                        principalTable: "TransportType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingPrivateTransport",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PrivateTransportId = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingPrivateTransport", x => new { x.UserId, x.PrivateTransportId });
                    table.ForeignKey(
                        name: "FK_BookingPrivateTransport_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingPrivateTransport_PrivateTransport_PrivateTransportId",
                        column: x => x.PrivateTransportId,
                        principalTable: "PrivateTransport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingPrivateTransport_PrivateTransportId",
                table: "BookingPrivateTransport",
                column: "PrivateTransportId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateTransport_TransportTypeId",
                table: "PrivateTransport",
                column: "TransportTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_UserId",
                table: "Report",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingEventDates_AspNetUsers_UserId",
                table: "BookingEventDates",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingEventDates_EventDates_EventDateId",
                table: "BookingEventDates",
                column: "EventDateId",
                principalTable: "EventDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventDates_Events_EventId",
                table: "EventDates",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventTypes_EventTypeId",
                table: "Events",
                column: "EventTypeId",
                principalTable: "EventTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingEventDates_AspNetUsers_UserId",
                table: "BookingEventDates");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingEventDates_EventDates_EventDateId",
                table: "BookingEventDates");

            migrationBuilder.DropForeignKey(
                name: "FK_EventDates_Events_EventId",
                table: "EventDates");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventTypes_EventTypeId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "BookingPrivateTransport");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "PrivateTransport");

            migrationBuilder.DropTable(
                name: "TransportType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventTypes",
                table: "EventTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventDates",
                table: "EventDates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingEventDates",
                table: "BookingEventDates");

            migrationBuilder.RenameTable(
                name: "EventTypes",
                newName: "EventType");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "Event");

            migrationBuilder.RenameTable(
                name: "EventDates",
                newName: "EventDate");

            migrationBuilder.RenameTable(
                name: "BookingEventDates",
                newName: "BookingEventDate");

            migrationBuilder.RenameIndex(
                name: "IX_Events_EventTypeId",
                table: "Event",
                newName: "IX_Event_EventTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_EventDates_EventId",
                table: "EventDate",
                newName: "IX_EventDate_EventId");

            migrationBuilder.RenameIndex(
                name: "IX_BookingEventDates_EventDateId",
                table: "BookingEventDate",
                newName: "IX_BookingEventDate_EventDateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventType",
                table: "EventType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Event",
                table: "Event",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventDate",
                table: "EventDate",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingEventDate",
                table: "BookingEventDate",
                columns: new[] { "UserId", "EventDateId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BookingEventDate_AspNetUsers_UserId",
                table: "BookingEventDate",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingEventDate_EventDate_EventDateId",
                table: "BookingEventDate",
                column: "EventDateId",
                principalTable: "EventDate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_EventType_EventTypeId",
                table: "Event",
                column: "EventTypeId",
                principalTable: "EventType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventDate_Event_EventId",
                table: "EventDate",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
