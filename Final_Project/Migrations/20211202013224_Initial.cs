using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TallestMountains",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    HeightInFeet = table.Column<int>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    Range = table.Column<string>(nullable: true),
                    Parent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TallestMountains", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TallestMountains",
                columns: new[] { "Id", "Country", "HeightInFeet", "Name", "Parent", "Range" },
                values: new object[,]
                {
                    { 1, "Nepal", 29029, "Mount Everest", "N/A", "Mahalangur Himalaya" },
                    { 2, "Pakistan", 28251, "K2", "Mount Everest", "Baltoro Karakoram" },
                    { 3, "Nepal", 28169, "Kangchenjunga", "Mount Everest", "Kangchenjunga Himalaya" },
                    { 4, "Nepal", 27940, "Lhoste", "Mount Everest", "Mahalangur Himalaya" },
                    { 5, "Nepal", 27838, "Makalu", "Mount Everest", "Mahalangur Himalaya" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TallestMountains");
        }
    }
}
