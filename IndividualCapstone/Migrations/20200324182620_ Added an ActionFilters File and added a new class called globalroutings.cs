using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class AddedanActionFiltersFileandaddedanewclasscalledglobalroutings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d223063-398f-473d-afb1-b72bfade5f2b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb8bd6ae-47c4-467c-9707-d68e9f5639e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf2a46ca-71aa-4079-b35c-44aabceebc54");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "cb8bd6ae-47c4-467c-9707-d68e9f5639e6", "4f1cb77b-2873-45ed-bd7d-cc8c74cf8b76", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cf2a46ca-71aa-4079-b35c-44aabceebc54", "0cc56062-1299-4c4c-98ae-b70ffc66e97e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d223063-398f-473d-afb1-b72bfade5f2b", "e36275ad-ecb9-4a62-9c00-440d92e127ee", "Employee", "EMPLOYEE" });
        }
    }
}
