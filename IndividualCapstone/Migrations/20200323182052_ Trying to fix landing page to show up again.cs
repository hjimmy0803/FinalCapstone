using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class Tryingtofixlandingpagetoshowupagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0887a131-1707-4a86-8ed0-d379b36e2945");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f1c6f42-4599-4136-be06-ad4abca2509d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b49442f-15d5-48a5-aaf1-bab6b1ec5475");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "0887a131-1707-4a86-8ed0-d379b36e2945", "28b0f681-d0b4-4c2e-84be-59f72d11be54", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b49442f-15d5-48a5-aaf1-bab6b1ec5475", "d2f755d7-5cce-41fc-a110-fb3706fa9ee6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2f1c6f42-4599-4136-be06-ad4abca2509d", "5b56a8b5-7dd4-41d9-b7cf-8a1cc9bedf93", "Employee", "EMPLOYEE" });
        }
    }
}
