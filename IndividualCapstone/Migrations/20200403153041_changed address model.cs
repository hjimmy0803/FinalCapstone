using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class changedaddressmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cbc0db5-5761-41b3-9780-249be9a974db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e188b6a9-ef35-48a8-8204-9e70c338ae2c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7647a16-192a-429c-8575-e21be44a3945");

            migrationBuilder.AlterColumn<double>(
                name: "Lng",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "Lat",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69e8e3d9-5b03-4293-a3f0-759fa00ef1cd", "482e5f84-f57c-427f-9758-e4c555d9be0a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b5d04ae2-ff7b-4d18-836e-2c0c27b7389e", "9d8bbe44-2b69-4080-9636-da8e657b10a3", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "48af8cde-f1f5-4bb2-aba1-eb5963c7d09b", "2919b27b-db04-4936-a6c6-3d9960a8ca20", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48af8cde-f1f5-4bb2-aba1-eb5963c7d09b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69e8e3d9-5b03-4293-a3f0-759fa00ef1cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5d04ae2-ff7b-4d18-836e-2c0c27b7389e");

            migrationBuilder.AlterColumn<double>(
                name: "Lng",
                table: "Addresses",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Lat",
                table: "Addresses",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e188b6a9-ef35-48a8-8204-9e70c338ae2c", "2e07b310-90e1-4c7b-a6c5-85a4ffaecc42", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e7647a16-192a-429c-8575-e21be44a3945", "6e9a331d-3122-4281-8cb5-0d1cd81a9ff6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0cbc0db5-5761-41b3-9780-249be9a974db", "64a99211-823a-4a6b-adb9-9717ca23d518", "Employee", "EMPLOYEE" });
        }
    }
}
