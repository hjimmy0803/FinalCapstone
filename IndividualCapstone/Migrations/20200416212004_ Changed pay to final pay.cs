using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class Changedpaytofinalpay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Pay",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "FinalPay",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e037f3f1-4552-4009-b960-1a244bfa6979", "98318af0-b701-45b8-8f55-3bf58c92e0b0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b340a0fb-04af-43e0-b33b-a81252bb2ce1", "574714aa-40fa-4d6c-afed-d1f941e8b00d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "feec2524-4c9f-4574-869b-b6c7976ffc2b", "3aa45988-fbef-486d-a538-05829c565440", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b340a0fb-04af-43e0-b33b-a81252bb2ce1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e037f3f1-4552-4009-b960-1a244bfa6979");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "feec2524-4c9f-4574-869b-b6c7976ffc2b");

            migrationBuilder.DropColumn(
                name: "FinalPay",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "Pay",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
