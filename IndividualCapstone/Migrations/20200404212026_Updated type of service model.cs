using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualCapstone.Migrations
{
    public partial class Updatedtypeofservicemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48af8cde-f1f5-4bb2-aba1-eb5963c7d09b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69e8e3d9-5b03-4293-a3f0-759fa00ef1cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5d04ae2-ff7b-4d18-836e-2c0c27b7389e");

            migrationBuilder.AddColumn<int>(
                name: "TypeOfServiceId",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TypeOfService",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rats = table.Column<string>(nullable: true),
                    Ants = table.Column<string>(nullable: true),
                    Wasps = table.Column<string>(nullable: true),
                    Bees = table.Column<string>(nullable: true),
                    Waterbugs = table.Column<string>(nullable: true),
                    Bedbugs = table.Column<string>(nullable: true),
                    Earwigs = table.Column<string>(nullable: true),
                    Silverfish = table.Column<string>(nullable: true),
                    YellowJackets = table.Column<string>(nullable: true),
                    Mice = table.Column<string>(nullable: true),
                    Spiders = table.Column<string>(nullable: true),
                    Roaches = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfService", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TypeOfServiceId",
                table: "Customers",
                column: "TypeOfServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_TypeOfService_TypeOfServiceId",
                table: "Customers",
                column: "TypeOfServiceId",
                principalTable: "TypeOfService",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_TypeOfService_TypeOfServiceId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "TypeOfService");

            migrationBuilder.DropIndex(
                name: "IX_Customers_TypeOfServiceId",
                table: "Customers");

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

            migrationBuilder.DropColumn(
                name: "TypeOfServiceId",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69e8e3d9-5b03-4293-a3f0-759fa00ef1cd", "482e5f84-f57c-427f-9758-e4c555d9be0a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b5d04ae2-ff7b-4d18-836e-2c0c27b7389e", "9d8bbe44-2b69-4080-9636-da8e657b10a3", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "48af8cde-f1f5-4bb2-aba1-eb5963c7d09b", "2919b27b-db04-4936-a6c6-3d9960a8ca20", "Employee", "EMPLOYEE" });
        }
    }
}
