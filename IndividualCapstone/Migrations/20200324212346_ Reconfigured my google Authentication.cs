using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class ReconfiguredmygoogleAuthentication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ab3808c-f08c-4159-99b1-3704e9c7f207");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34c353a3-c43b-42bd-b1ef-ced6a1b39ae0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2836eb2-65ec-4298-99bd-9f487ea7c439");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b88ae3d-2eba-4787-a4d6-714556656645", "77654f8e-9026-440f-89e0-5f663a2c9b96", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "494d8a7c-0a54-49cf-a979-a8af09bdbffc", "8d945b7a-e119-4baa-82ee-b710a99a7667", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "95728b90-1537-45bf-a5d6-9be6a4b99021", "07feb8be-4808-40c8-998b-96b160be548c", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b88ae3d-2eba-4787-a4d6-714556656645");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "494d8a7c-0a54-49cf-a979-a8af09bdbffc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95728b90-1537-45bf-a5d6-9be6a4b99021");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0ab3808c-f08c-4159-99b1-3704e9c7f207", "fe9f2dea-8998-4a46-9a8d-6884c3b4c7e0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2836eb2-65ec-4298-99bd-9f487ea7c439", "4cd986c7-b963-469c-9f39-d3ab02c2e489", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "34c353a3-c43b-42bd-b1ef-ced6a1b39ae0", "4e247785-b27f-4c87-bd41-ca3efad16f80", "Employee", "EMPLOYEE" });
        }
    }
}
