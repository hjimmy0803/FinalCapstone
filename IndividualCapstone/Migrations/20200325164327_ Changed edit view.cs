using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class Changededitview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "5ba47805-d39f-448c-aeea-24110aaa24ac", "6fb357db-d599-4a72-b5a7-da0d0ea8b25b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1aee2d57-2111-49f4-a81f-e15f35a13308", "67e52aaf-9449-43d9-a0dd-7debf13e556e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "277a0f37-e304-4b61-99da-74442bd540ff", "a740a4a3-0504-4d4a-b117-242a1ca9334a", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1aee2d57-2111-49f4-a81f-e15f35a13308");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "277a0f37-e304-4b61-99da-74442bd540ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ba47805-d39f-448c-aeea-24110aaa24ac");

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
    }
}
