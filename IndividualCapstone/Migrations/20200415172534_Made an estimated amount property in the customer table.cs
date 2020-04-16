using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class Madeanestimatedamountpropertyinthecustomertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<double>(
                name: "EstimatedAmount",
                table: "Customers",
                nullable: false,
                defaultValue: 0.0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "EstimatedAmount",
                table: "Customers");

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
    }
}
