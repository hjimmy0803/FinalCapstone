using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class chagedlongtolng : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a800f4e-c3d6-44fb-bd50-6000b3b22341");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c62968c7-8407-42f5-9f46-86857a701742");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc4a562f-ee61-41e6-8fc1-ececb2ab958b");

            migrationBuilder.DropColumn(
                name: "Long",
                table: "Addresses");

            migrationBuilder.AddColumn<double>(
                name: "Lng",
                table: "Addresses",
                nullable: false,
                defaultValue: 0.0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Lng",
                table: "Addresses");

            migrationBuilder.AddColumn<double>(
                name: "Long",
                table: "Addresses",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fc4a562f-ee61-41e6-8fc1-ececb2ab958b", "3ee1f07d-f657-4162-b1d3-b29dce1bba12", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9a800f4e-c3d6-44fb-bd50-6000b3b22341", "8a9d1a16-2590-4b25-bd1e-def80f140306", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c62968c7-8407-42f5-9f46-86857a701742", "bb2dfc2e-acfa-4d45-b33c-642bab5a4d3d", "Employee", "EMPLOYEE" });
        }
    }
}
