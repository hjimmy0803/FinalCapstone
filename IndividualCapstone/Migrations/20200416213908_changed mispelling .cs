using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class changedmispelling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b340a0fb-04af-43e0-b33b-a81252bb2ce1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e037f3f1-4552-4009-b960-1a244bfa6979");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "feec2524-4c9f-4574-869b-b6c7976ffc2b");

            migrationBuilder.DropColumn(
                name: "ServiceAccpeted",
                table: "Customers");

            migrationBuilder.AddColumn<bool>(
                name: "ServiceAccepted",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46a20dc2-d7c0-41a5-adb0-6fe22c73abbc", "035ed774-ee0e-47c3-b17b-321cb2f2f89b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7af541f7-6cb2-4870-890e-003434759899", "89f6a32e-d79b-4480-a42d-8739fbe97b44", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2482d654-fd3a-47cf-89dc-649c6b0f1fb0", "3815aac5-4520-4417-a910-a4da38ad5945", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2482d654-fd3a-47cf-89dc-649c6b0f1fb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46a20dc2-d7c0-41a5-adb0-6fe22c73abbc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7af541f7-6cb2-4870-890e-003434759899");

            migrationBuilder.DropColumn(
                name: "ServiceAccepted",
                table: "Customers");

            migrationBuilder.AddColumn<bool>(
                name: "ServiceAccpeted",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e037f3f1-4552-4009-b960-1a244bfa6979", "98318af0-b701-45b8-8f55-3bf58c92e0b0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b340a0fb-04af-43e0-b33b-a81252bb2ce1", "574714aa-40fa-4d6c-afed-d1f941e8b00d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "feec2524-4c9f-4574-869b-b6c7976ffc2b", "3aa45988-fbef-486d-a538-05829c565440", "Employee", "EMPLOYEE" });
        }
    }
}
