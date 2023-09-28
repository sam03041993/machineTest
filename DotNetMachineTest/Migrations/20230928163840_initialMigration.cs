using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetMachineTest.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConversionRate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromUnitId = table.Column<int>(nullable: false),
                    ToUnitId = table.Column<int>(nullable: false),
                    Rate = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConversionRate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ConversionRate",
                columns: new[] { "Id", "FromUnitId", "Rate", "ToUnitId" },
                values: new object[,]
                {
                    { 1, 1, 1.8, 2 },
                    { 2, 2, 0.55556000000000005, 1 },
                    { 3, 3, 3.28084, 4 },
                    { 4, 4, 0.30399999999999999, 5 }
                });

            migrationBuilder.InsertData(
                table: "Unit",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Celsius" },
                    { 2, "Fahrenheit" },
                    { 3, "Meter" },
                    { 4, "Feet" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConversionRate");

            migrationBuilder.DropTable(
                name: "Unit");
        }
    }
}
