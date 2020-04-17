using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class Addeddeclineandacceptinthecustomermodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "ServiceAccpeted",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8fe31727-858c-4e7b-9605-a4a87cf9eaf3", "382ddd23-4bd5-42ce-adea-d41a8e0bd938", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "13d4d6e0-79c4-43ee-8e91-b36c3b66e67e", "5a9faee6-953a-47e1-92d5-23980fdf9f16", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c2f0925f-f9d8-4e79-bcd0-fb3c2a22dc82", "8e0e0a08-0d7b-4840-9383-5f6940a4e9a3", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13d4d6e0-79c4-43ee-8e91-b36c3b66e67e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fe31727-858c-4e7b-9605-a4a87cf9eaf3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2f0925f-f9d8-4e79-bcd0-fb3c2a22dc82");

            migrationBuilder.DropColumn(
                name: "ServiceAccpeted",
                table: "Customers");

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
    }
}
