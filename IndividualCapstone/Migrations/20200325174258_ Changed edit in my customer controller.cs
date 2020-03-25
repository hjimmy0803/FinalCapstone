using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class Changededitinmycustomercontroller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1aee2d57-2111-49f4-a81f-e15f35a13308");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "277a0f37-e304-4b61-99da-74442bd540ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ba47805-d39f-448c-aeea-24110aaa24ac");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94fd6427-618c-467d-9855-d363dcd24680", "22f707f3-4498-4cad-9048-22b49836fbb0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5cb89d3d-11b4-41cf-be08-09379b614750", "04da67c0-1ffa-4501-b22e-8c3e45107bf2", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8f25abb2-e1a8-4a12-bc21-6fffec2c21c9", "0b6ae758-5599-41c1-a88d-492ec1d2b18e", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cb89d3d-11b4-41cf-be08-09379b614750");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f25abb2-e1a8-4a12-bc21-6fffec2c21c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94fd6427-618c-467d-9855-d363dcd24680");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ba47805-d39f-448c-aeea-24110aaa24ac", "6fb357db-d599-4a72-b5a7-da0d0ea8b25b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1aee2d57-2111-49f4-a81f-e15f35a13308", "67e52aaf-9449-43d9-a0dd-7debf13e556e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "277a0f37-e304-4b61-99da-74442bd540ff", "a740a4a3-0504-4d4a-b117-242a1ca9334a", "Employee", "EMPLOYEE" });
        }
    }
}
