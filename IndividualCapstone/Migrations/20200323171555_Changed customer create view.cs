using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class Changedcustomercreateview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a9ba304-7e5c-4bdf-bc96-cf4dd3e1a495");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79df5822-a345-4e02-aa0b-b876899f8a68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2786ed5-59d9-4d3e-bf76-a3e9a7c231d8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0887a131-1707-4a86-8ed0-d379b36e2945", "28b0f681-d0b4-4c2e-84be-59f72d11be54", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b49442f-15d5-48a5-aaf1-bab6b1ec5475", "d2f755d7-5cce-41fc-a110-fb3706fa9ee6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2f1c6f42-4599-4136-be06-ad4abca2509d", "5b56a8b5-7dd4-41d9-b7cf-8a1cc9bedf93", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0887a131-1707-4a86-8ed0-d379b36e2945");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f1c6f42-4599-4136-be06-ad4abca2509d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b49442f-15d5-48a5-aaf1-bab6b1ec5475");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2786ed5-59d9-4d3e-bf76-a3e9a7c231d8", "37a91eb7-b457-423c-a409-1a0eae9c9acf", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3a9ba304-7e5c-4bdf-bc96-cf4dd3e1a495", "f82970f1-4f60-4cd2-8340-a0d447f3a633", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "79df5822-a345-4e02-aa0b-b876899f8a68", "e796c4bb-5dea-490b-bd75-b60c9c460e0f", "Employee", "EMPLOYEE" });
        }
    }
}
