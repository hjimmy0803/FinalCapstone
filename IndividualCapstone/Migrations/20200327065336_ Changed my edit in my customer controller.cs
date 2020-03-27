using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class Changedmyeditinmycustomercontroller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "bc510c18-98a6-4b96-89a4-006ecf857d1f", "b4b49700-7dea-4f7a-a33d-a491c57745b5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b4cdfaf8-7882-4db0-868e-7ce82880d224", "8ab44279-a737-4ff5-b2df-7359f36a537b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f170bdcb-a3f9-4467-8b87-d298d333f6a2", "c02c0e48-5888-49b9-8e1d-2c82e5a80267", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4cdfaf8-7882-4db0-868e-7ce82880d224");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc510c18-98a6-4b96-89a4-006ecf857d1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f170bdcb-a3f9-4467-8b87-d298d333f6a2");

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
    }
}
