using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class Decidedtonotmakeapaymentmodelintoatable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35485f00-8bb6-4dc2-8047-48ee43ee65c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "495d27c3-6cdb-4e31-9d03-314552efbbe3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70e9a833-55cd-4bc5-9349-003d349b7ea3");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "70e9a833-55cd-4bc5-9349-003d349b7ea3", "2f5df3e3-3632-4627-8eef-a1463edbb577", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "35485f00-8bb6-4dc2-8047-48ee43ee65c5", "786e2dfd-c5ed-4a39-b357-4406de9118a6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "495d27c3-6cdb-4e31-9d03-314552efbbe3", "1cbbfcd3-e595-4986-888d-3ae784ff4fb6", "Employee", "EMPLOYEE" });
        }
    }
}
