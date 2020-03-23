using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class Addedgoogleauthentication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "768f7509-1d11-4e6f-a061-c03abaa45875");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e36c42b-47f6-49b5-a765-e012a2c5815e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b118f87a-1fea-49f5-bd26-7199a28b3499");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "b118f87a-1fea-49f5-bd26-7199a28b3499", "bb9f1751-1908-427d-a08a-affab0f76eb5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "768f7509-1d11-4e6f-a061-c03abaa45875", "4389598f-2afa-495c-8aae-cf0c2c72cb19", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9e36c42b-47f6-49b5-a765-e012a2c5815e", "fca8614b-4115-40a5-9b5c-043295f041aa", "Employee", "EMPLOYEE" });
        }
    }
}
