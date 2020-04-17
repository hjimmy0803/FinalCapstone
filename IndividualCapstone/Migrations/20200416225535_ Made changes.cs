using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class Madechanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "767d6e12-37d7-4b0c-9ec0-3b9eaa8ab8ee", "ddce679a-5d1a-4871-a381-c5700c0f129c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d103155-fdd2-45e9-8d99-b93541508fc6", "d0b03f4d-e28e-40f1-82d0-7d88a2236939", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "50a27fe3-f491-4d87-8140-d21dcd9ae104", "0066bd34-8648-4a7f-85a3-e34347eaae25", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d103155-fdd2-45e9-8d99-b93541508fc6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50a27fe3-f491-4d87-8140-d21dcd9ae104");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "767d6e12-37d7-4b0c-9ec0-3b9eaa8ab8ee");

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
    }
}
