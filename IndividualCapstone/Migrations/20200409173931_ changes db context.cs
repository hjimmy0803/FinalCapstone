using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class changesdbcontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5eb07d21-40ca-407f-996d-8ed9f27b4e52");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6055c24a-1e99-4eb6-b5a9-b172dcb10dbc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72fdf7af-245d-499c-8e63-06ceabba8807");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "15b8449d-d5c9-4fd9-a8ce-5df71d5f26f9", "dc502337-142e-44f5-b9d0-8ef41ca59d49", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b3c42861-8463-4b44-a695-3b1395b0f347", "1c735912-a5c5-4f5a-a146-1e3d36e1dbaf", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b8864d97-51d7-43b7-81bd-8e4f40e2e8ad", "8294532c-b434-47b8-8c1f-33464b586029", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15b8449d-d5c9-4fd9-a8ce-5df71d5f26f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3c42861-8463-4b44-a695-3b1395b0f347");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8864d97-51d7-43b7-81bd-8e4f40e2e8ad");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6055c24a-1e99-4eb6-b5a9-b172dcb10dbc", "752182f9-9131-4aaf-b7ee-b6a8b9efe666", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "72fdf7af-245d-499c-8e63-06ceabba8807", "7d736ee3-d723-4696-b16c-dd42893c0be5", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5eb07d21-40ca-407f-996d-8ed9f27b4e52", "52aba519-ce2c-4005-a1f8-233988bc1d3c", "Employee", "EMPLOYEE" });
        }
    }
}
