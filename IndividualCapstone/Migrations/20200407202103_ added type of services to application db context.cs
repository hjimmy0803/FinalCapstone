using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class addedtypeofservicestoapplicationdbcontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_TypeOfService_TypeOfServiceId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeOfService",
                table: "TypeOfService");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d210111b-dbe5-459a-8069-da719fb8ad81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbbbdbf1-57fe-43e7-adea-1c4efcd4fc3a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff4ef315-5672-48a1-b76b-fa01d2293800");

            migrationBuilder.RenameTable(
                name: "TypeOfService",
                newName: "TypeOfServices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeOfServices",
                table: "TypeOfServices",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_TypeOfServices_TypeOfServiceId",
                table: "Customers",
                column: "TypeOfServiceId",
                principalTable: "TypeOfServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_TypeOfServices_TypeOfServiceId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeOfServices",
                table: "TypeOfServices");

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

            migrationBuilder.RenameTable(
                name: "TypeOfServices",
                newName: "TypeOfService");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeOfService",
                table: "TypeOfService",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dbbbdbf1-57fe-43e7-adea-1c4efcd4fc3a", "cc293b27-2ce1-4fca-94c8-af4093824fe8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d210111b-dbe5-459a-8069-da719fb8ad81", "44285ae1-eaa0-4915-a2c0-660d0c29752d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff4ef315-5672-48a1-b76b-fa01d2293800", "9fbdb917-8fe6-4c9a-b402-7ec347848539", "Employee", "EMPLOYEE" });

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_TypeOfService_TypeOfServiceId",
                table: "Customers",
                column: "TypeOfServiceId",
                principalTable: "TypeOfService",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
