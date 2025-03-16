using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserRoleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "10eb7637-95f4-45d2-b200-84dbb188ec41" },
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "249aa6c5-d578-4517-8a42-48f24a7d959e" },
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "357c8ce0-ed6e-4979-b1f9-5e0f6e90c9a1" },
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "49a438ba-672d-41d5-97ba-5536ffbec2a6" },
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "52511e3a-0690-45b0-9e52-02667a473b18" },
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "5d577849-97d1-4984-bf96-6fee7d08c8be" },
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "683211b1-1125-42a1-b148-a606a4ca4df3" },
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "6b9b3e85-ce32-4944-9a46-601bb2b40000" },
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "7c30ae16-67eb-4ff2-858f-70aa79aaa3c4" },
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "8766c317-1eaa-468a-b34d-59790c8eb915" },
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "a0e2f1e7-53e5-416f-b0b0-ca4668563233" },
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "bf2ee728-59af-45ec-9b70-e5f5e27eef8e" },
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "cb3cb7ca-1921-49fd-a11e-600b351b3df2" },
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "cb3cb7ca-1921-49fd-a11e-600b351b3df3" },
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "cb3cb7ca-1921-49fd-a11e-600b351b3df4" },
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "ce47a5ab-df14-416a-b500-9b544fa666a4" },
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "df2ea217-2e82-48b9-9442-47556c1a9403" },
                    { "0191d311-2918-7f76-bd8a-0bded8535075", "e4b2f91d-9e12-4f4a-b3db-1b58fca15e66" },
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "f89bca4a-8fc9-4259-a46d-22562907c27f" },
                    { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "fc4df06f-05c2-4751-96c1-8040f2761b7f" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "10eb7637-95f4-45d2-b200-84dbb188ec41" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "249aa6c5-d578-4517-8a42-48f24a7d959e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "357c8ce0-ed6e-4979-b1f9-5e0f6e90c9a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "49a438ba-672d-41d5-97ba-5536ffbec2a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "52511e3a-0690-45b0-9e52-02667a473b18" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "5d577849-97d1-4984-bf96-6fee7d08c8be" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "683211b1-1125-42a1-b148-a606a4ca4df3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "6b9b3e85-ce32-4944-9a46-601bb2b40000" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "7c30ae16-67eb-4ff2-858f-70aa79aaa3c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "8766c317-1eaa-468a-b34d-59790c8eb915" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "a0e2f1e7-53e5-416f-b0b0-ca4668563233" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "bf2ee728-59af-45ec-9b70-e5f5e27eef8e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "cb3cb7ca-1921-49fd-a11e-600b351b3df2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "cb3cb7ca-1921-49fd-a11e-600b351b3df3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "cb3cb7ca-1921-49fd-a11e-600b351b3df4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "ce47a5ab-df14-416a-b500-9b544fa666a4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "df2ea217-2e82-48b9-9442-47556c1a9403" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bded8535075", "e4b2f91d-9e12-4f4a-b3db-1b58fca15e66" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "f89bca4a-8fc9-4259-a46d-22562907c27f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6CCF2454-C7FE-4F58-89FB-F565AE5643E3", "fc4df06f-05c2-4751-96c1-8040f2761b7f" });
        }
    }
}
