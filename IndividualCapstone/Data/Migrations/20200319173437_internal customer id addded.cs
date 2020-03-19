using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Data.Migrations
{
    public partial class internalcustomeridaddded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "115723b0-b27f-4e46-9cf1-6d2d5f064b85");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3abb945-b9d2-4650-bf33-408719d977e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccf640cf-5124-4acb-a8e6-5a968e362fdc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "35494e27-5ec4-4e57-8272-ecc2cd99a129", "95babe59-dba3-4fe8-a84f-9621887e67eb", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b5433f3-0f7f-4cff-a140-ff58c8b80d1e", "b786646f-aaa8-48f1-9646-80bb69492660", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6ac70f97-7796-4466-84fe-433761732e7d", "b91ce8b7-d10b-44ba-b13c-b4db6efd85a7", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b5433f3-0f7f-4cff-a140-ff58c8b80d1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35494e27-5ec4-4e57-8272-ecc2cd99a129");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ac70f97-7796-4466-84fe-433761732e7d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ccf640cf-5124-4acb-a8e6-5a968e362fdc", "aa8f95cf-cfdf-4779-9f56-a764224df8b8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "115723b0-b27f-4e46-9cf1-6d2d5f064b85", "2fe07ba0-f49e-4c65-99a0-312fc71187d6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3abb945-b9d2-4650-bf33-408719d977e6", "66b01d6c-eea8-447e-a1b6-5f12f4378526", "Employee", "EMPLOYEE" });
        }
    }
}
