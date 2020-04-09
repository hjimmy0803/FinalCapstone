using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class makinganewtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4cdfaf8-7882-4db0-868e-7ce82880d224");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc510c18-98a6-4b96-89a4-006ecf857d1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f170bdcb-a3f9-4467-8b87-d298d333f6a2");

            migrationBuilder.DropColumn(
                name: "TypeOfService",
                table: "Accounts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a7e0eb4-f131-4da5-9976-09c6f49c2461", "6f7b79fa-cdf1-4243-8b21-e510a4595174", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c6f7684-d189-422d-b8d5-cd37b626fe7c", "56d1a5d5-0604-4666-b6e7-df6447a7e648", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "91d71067-3546-4406-bc48-d527398d27a4", "8c12433a-3845-4c59-ae56-284baf253825", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c6f7684-d189-422d-b8d5-cd37b626fe7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a7e0eb4-f131-4da5-9976-09c6f49c2461");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91d71067-3546-4406-bc48-d527398d27a4");

            migrationBuilder.AddColumn<string>(
                name: "TypeOfService",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc510c18-98a6-4b96-89a4-006ecf857d1f", "b4b49700-7dea-4f7a-a33d-a491c57745b5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b4cdfaf8-7882-4db0-868e-7ce82880d224", "8ab44279-a737-4ff5-b2df-7359f36a537b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f170bdcb-a3f9-4467-8b87-d298d333f6a2", "c02c0e48-5888-49b9-8e1d-2c82e5a80267", "Employee", "EMPLOYEE" });
        }
    }
}
