using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class addedtomyaddressmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<double>(
                name: "Lat",
                table: "Addresses",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Long",
                table: "Addresses",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Lat",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Long",
                table: "Addresses");

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
    }
}
