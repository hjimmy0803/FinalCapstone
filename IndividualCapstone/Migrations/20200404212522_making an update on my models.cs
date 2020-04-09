using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class makinganupdateonmymodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a1e9395-84db-4d56-b4c1-c0e4ffd039c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e7f5373-a572-4179-9b97-13b2a10a8c40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3adfdb9-8cee-4022-8250-bad89dc98a8a");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f3adfdb9-8cee-4022-8250-bad89dc98a8a", "40135d4f-4881-4a25-a86a-953f2e4f774b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6a1e9395-84db-4d56-b4c1-c0e4ffd039c7", "bd7ba54f-cb74-40f7-aae5-d4ed4867ba10", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e7f5373-a572-4179-9b97-13b2a10a8c40", "5c02fd6b-28f1-4ca4-b737-c3c44c271b2d", "Employee", "EMPLOYEE" });
        }
    }
}
