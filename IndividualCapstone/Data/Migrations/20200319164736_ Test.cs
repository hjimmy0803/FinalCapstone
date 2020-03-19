using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Data.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f4de729-8c47-45bd-a1b6-79df073f17ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95ba894d-3d59-4451-9f65-12d03eb5080a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7bac747-9888-46d3-ae79-959c632587f6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aa6eb5d6-9f1c-4079-a444-2bd02e3d71e5", "4fcacbd1-49c8-485b-89a2-d7c4619a9445", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "22ebdd8c-b97d-4a26-8f4a-2504cd1aa352", "73d86cb8-eb01-4978-8783-2624a1fcfffb", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "24573105-e665-4be9-a810-cdd538477c2f", "034875c1-3ae0-421f-a398-f6e39b5cd20b", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ebdd8c-b97d-4a26-8f4a-2504cd1aa352");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24573105-e665-4be9-a810-cdd538477c2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa6eb5d6-9f1c-4079-a444-2bd02e3d71e5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "95ba894d-3d59-4451-9f65-12d03eb5080a", "a0094bd5-eab3-43fe-983f-a3316895f0cc", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5f4de729-8c47-45bd-a1b6-79df073f17ec", "c01a0c35-3b05-4fdc-a9e7-6a9809dffb6a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b7bac747-9888-46d3-ae79-959c632587f6", "21e16e90-7c79-45a9-b796-d04f61ce9349", "Employee", "EMPLOYEE" });
        }
    }
}
