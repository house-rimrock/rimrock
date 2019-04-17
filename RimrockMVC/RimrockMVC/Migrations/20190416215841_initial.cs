using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RimrockMVC.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavLocations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    RegionId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Cost = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FavRetailers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    RegionId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Specialty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavRetailers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "FavLocations",
                columns: new[] { "Id", "Cost", "Name", "RegionId", "UserId" },
                values: new object[,]
                {
                    { 1, "$", "TestLocation", 1, 1 },
                    { 2, "$", "TestLocation2", 1, 1 },
                    { 3, "$", "TestLocation3", 1, 2 },
                    { 4, "$", "TestLocation4", 1, 1 },
                    { 5, "$", "TestLocation5", 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "FavRetailers",
                columns: new[] { "Id", "Name", "RegionId", "Specialty", "UserId" },
                values: new object[,]
                {
                    { 1, "TestRetailer", 1, "Stuff", 1 },
                    { 2, "TestRetailer2", 1, "Stuff", 2 },
                    { 3, "TestRetailer3", 1, "Stuff", 2 },
                    { 4, "TestRetailer4", 1, "Stuff", 1 },
                    { 5, "TestRetailer5", 1, "Stuff", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "TestUserOne" },
                    { 2, "TestUserTwo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavLocations");

            migrationBuilder.DropTable(
                name: "FavRetailers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
