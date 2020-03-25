using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class Changedmyeditview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b88ae3d-2eba-4787-a4d6-714556656645");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "494d8a7c-0a54-49cf-a979-a8af09bdbffc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95728b90-1537-45bf-a5d6-9be6a4b99021");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ded5ce8-bfb0-473a-bdef-e8927ee34d83", "312e40f0-fd33-4ff9-b00d-b7433b0918ef", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "05eea229-ecd8-4667-af40-e96f1941c0be", "11a2c4f5-62b9-421f-be1d-a53049b1bf59", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aa8ce9eb-3ce5-4786-932b-7a186b0fbb5a", "577ac61e-0abf-4455-8d73-51b717f30471", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05eea229-ecd8-4667-af40-e96f1941c0be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ded5ce8-bfb0-473a-bdef-e8927ee34d83");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa8ce9eb-3ce5-4786-932b-7a186b0fbb5a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b88ae3d-2eba-4787-a4d6-714556656645", "77654f8e-9026-440f-89e0-5f663a2c9b96", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "494d8a7c-0a54-49cf-a979-a8af09bdbffc", "8d945b7a-e119-4baa-82ee-b710a99a7667", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "95728b90-1537-45bf-a5d6-9be6a4b99021", "07feb8be-4808-40c8-998b-96b160be548c", "Employee", "EMPLOYEE" });
        }
    }
}
