using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class gavedisplaynamestomytypesofservices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9754e6e5-dd78-415e-836c-db3a8040fde3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea1952cd-d21f-43b9-9246-f05a994c4959");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee08a683-095e-4db9-ab83-7ca3451d60c3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5cdbcbe0-1472-4c2e-8e09-5e060fc8f0cd", "af7afd72-7b3d-4e0e-b25e-ae60b0c222e8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac494573-bac5-446f-b39e-5f241609f5ed", "ebd0ade9-be90-48b4-9317-e7f9161f91e4", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f65bc74d-9135-4f7e-af30-a2802a130286", "50219c68-316d-4161-82cf-5f991363061f", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cdbcbe0-1472-4c2e-8e09-5e060fc8f0cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac494573-bac5-446f-b39e-5f241609f5ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f65bc74d-9135-4f7e-af30-a2802a130286");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9754e6e5-dd78-415e-836c-db3a8040fde3", "d12ae5de-35a0-4b8c-b6dc-94fa828066f8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ea1952cd-d21f-43b9-9246-f05a994c4959", "5aa3a505-f544-46d7-92b1-991ae0368b39", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ee08a683-095e-4db9-ab83-7ca3451d60c3", "f8996135-ff76-46dd-a8dd-838645f0dc67", "Employee", "EMPLOYEE" });
        }
    }
}
