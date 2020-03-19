using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Data.Migrations
{
    public partial class Changedservicemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b5433f3-0f7f-4cff-a140-ff58c8b80d1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35494e27-5ec4-4e57-8272-ecc2cd99a129");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ac70f97-7796-4466-84fe-433761732e7d");

            migrationBuilder.DropColumn(
                name: "BiMonthlyService",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "MonthlySerice",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "QuarterlyService",
                table: "Accounts");

            migrationBuilder.AddColumn<bool>(
                name: "IsSuspended",
                table: "Accounts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "TypeOfService",
                table: "Accounts",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fafccb87-8823-4feb-90dd-f154099e9d1d", "6ad46f32-882f-4b79-8819-01456ea52ab5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "028a4eae-56ba-4626-9cc6-da8b8b15e403", "5471933d-c5ff-48f4-b4cf-f78ed39f14fe", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "471804e7-babc-49d0-a1e6-9220cfcfaf5a", "32757b43-60ac-4197-a526-fc239c2efd8a", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "028a4eae-56ba-4626-9cc6-da8b8b15e403");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "471804e7-babc-49d0-a1e6-9220cfcfaf5a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fafccb87-8823-4feb-90dd-f154099e9d1d");

            migrationBuilder.DropColumn(
                name: "IsSuspended",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "TypeOfService",
                table: "Accounts");

            migrationBuilder.AddColumn<string>(
                name: "BiMonthlyService",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MonthlySerice",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QuarterlyService",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "35494e27-5ec4-4e57-8272-ecc2cd99a129", "95babe59-dba3-4fe8-a84f-9621887e67eb", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b5433f3-0f7f-4cff-a140-ff58c8b80d1e", "b786646f-aaa8-48f1-9646-80bb69492660", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6ac70f97-7796-4466-84fe-433761732e7d", "b91ce8b7-d10b-44ba-b13c-b4db6efd85a7", "Employee", "EMPLOYEE" });
        }
    }
}
