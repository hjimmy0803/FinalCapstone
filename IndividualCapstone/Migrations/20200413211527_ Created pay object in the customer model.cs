using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class Createdpayobjectinthecustomermodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Pay",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5d250b71-a603-4c4e-bb4d-27487148825f", "3badd62d-fca8-4513-a14d-169db2a320b2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "16d48e4f-187d-4e45-bf8d-62677243e19e", "29f60589-d548-464e-9f0c-a523ec563a11", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a456995-b170-436f-a5b7-9d35149b0726", "bdc716af-99e6-4747-91b3-8461384a4f81", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16d48e4f-187d-4e45-bf8d-62677243e19e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d250b71-a603-4c4e-bb4d-27487148825f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a456995-b170-436f-a5b7-9d35149b0726");

            migrationBuilder.DropColumn(
                name: "Pay",
                table: "Customers");

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
    }
}
