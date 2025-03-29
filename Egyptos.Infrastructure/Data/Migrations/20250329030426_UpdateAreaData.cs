using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAreaData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "Location" },
                values: new object[] { "AreaImages/The Unfinished Obelisk1.jpg", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3642.698997832703!2d32.89801192519799!3d24.076902176164435!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x143664aa5c33aa3f%3A0xa1bf171a1b3086c6!2z2KfZhNmF2LPZhNipINin2YTZhtin2YLYtdip!5e0!3m2!1sar!2seg!4v1743217417901!5m2!1sar!2seg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "Location" },
                values: new object[] { "AreaImages\\The Unfinished Obelisk1.jpg", "" });
        }
    }
}
