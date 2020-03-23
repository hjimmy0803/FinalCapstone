using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class ChangedtheIndexformattingintheHomeController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "057bc502-432d-4655-90d2-0a0f752f8012");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81c934bc-9477-4a0f-af76-9e76270e8dce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad224fdb-9e99-4b58-b964-e43e8f586c8e");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "81c934bc-9477-4a0f-af76-9e76270e8dce", "b3c68aec-8bc9-482f-87a8-e71c3903e386", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "057bc502-432d-4655-90d2-0a0f752f8012", "f5e53cbf-551a-4209-8da7-1a09c851da07", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad224fdb-9e99-4b58-b964-e43e8f586c8e", "036af01e-2531-4be2-8da0-846453a2239f", "Employee", "EMPLOYEE" });
        }
    }
}
