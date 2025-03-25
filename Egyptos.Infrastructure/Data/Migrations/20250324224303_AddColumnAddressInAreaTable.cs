using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnAddressInAreaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Areas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Areas");
        }
    }
}
