using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class Addednewpropertytocustomerclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50f4d8e3-c9bb-4e3a-aecd-449d2c21a4a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5871ede8-12dc-4019-a375-3126e756fffb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79d8c930-e658-4824-9140-34c588a269ce");

            migrationBuilder.AddColumn<bool>(
                name: "ServiceDenied",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c8129159-80d4-4561-9379-95dcc63f668e", "c899d3d8-0c69-43b7-933e-61ebd649c619", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ae4a7703-047f-4a98-9545-c7c95be0dcb7", "01c86e2b-8bbb-40a7-9999-fa42f9dfb31b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d1b3dd11-c986-4bbf-a86b-732752c3f53c", "f960c826-f064-4fd9-9b66-08a934d5fe3f", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae4a7703-047f-4a98-9545-c7c95be0dcb7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8129159-80d4-4561-9379-95dcc63f668e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1b3dd11-c986-4bbf-a86b-732752c3f53c");

            migrationBuilder.DropColumn(
                name: "ServiceDenied",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5871ede8-12dc-4019-a375-3126e756fffb", "a015a928-be0b-43b0-a6a2-9a0afc044a74", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "79d8c930-e658-4824-9140-34c588a269ce", "688167ee-46c9-4591-b8d1-7d8376a9d9fc", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "50f4d8e3-c9bb-4e3a-aecd-449d2c21a4a2", "84c45cd2-9ee1-4838-8488-fadc61376776", "Employee", "EMPLOYEE" });
        }
    }
}
