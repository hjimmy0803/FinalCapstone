using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class Tryingtogeteditcontrollertowork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4e7d8a2d-ad97-4d46-b50e-f064c49c383a", "201b700d-9932-4795-a08f-40310b925b36", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "327aeb12-e3e1-4f82-ae37-2a5ea63cb74d", "813a9ed7-982d-4b6d-a75d-70f327be7798", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "08c889ef-c0f5-46e6-a8bf-639f6b04e860", "52132005-9b60-4ba6-b129-b6038d1d9a4d", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08c889ef-c0f5-46e6-a8bf-639f6b04e860");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "327aeb12-e3e1-4f82-ae37-2a5ea63cb74d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e7d8a2d-ad97-4d46-b50e-f064c49c383a");

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
    }
}
