using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Migrations
{
    public partial class Tsunamis5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TallestTsunamisss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Element = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    HeightInFeet = table.Column<int>(nullable: false),
                    Where = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TallestTsunamisss", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TallestTsunamisss",
                columns: new[] { "Id", "Element", "HeightInFeet", "Type", "Where", "Year" },
                values: new object[,]
                {
                    { 1, "Water", 1720, "Megatsunami", "Alaska", 1958 },
                    { 2, "Water", 820, "Tsunami", "Washington", 1980 },
                    { 3, "Water", 771, "Tsunami", "Italy", 1963 },
                    { 4, "Water", 633, "Megatsunami", "Alaska", 2015 },
                    { 5, "Water", 490, "Tsunami", "Alaska", 1936 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TallestTsunamisss");
        }
    }
}
