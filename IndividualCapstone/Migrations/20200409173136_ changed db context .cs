using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class changeddbcontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33f2f0fd-0c24-4a95-9c03-190342a07cd0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dae541f-c145-4852-92c3-9740f6aa3052");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b1a4a20-633e-4b4d-990e-6a1508fa40b5");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "3dae541f-c145-4852-92c3-9740f6aa3052", "c85340de-a8fb-4cdb-81e0-7868d4635b75", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b1a4a20-633e-4b4d-990e-6a1508fa40b5", "12bdb487-8ff7-4cb2-9869-1368e8db6de3", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "33f2f0fd-0c24-4a95-9c03-190342a07cd0", "e2de15cd-e302-42e1-82e1-109fb873ffe8", "Employee", "EMPLOYEE" });
        }
    }
}
