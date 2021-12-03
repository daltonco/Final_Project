using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BestTeams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Sport = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    League = table.Column<string>(nullable: true),
                    Titles = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BestTeams", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BestTeams",
                columns: new[] { "Id", "Country", "League", "Name", "Sport", "Titles" },
                values: new object[,]
                {
                    { 1, "England", "Premier League", "Arsenal FC", "Soccer", 3 },
                    { 2, "USA", "NFL", "Bengals", "Football", 0 },
                    { 3, "USA", "NFL", "Browns", "Football", 4 },
                    { 4, "USA", "MLB", "Reds", "Baseball", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BestTeams");
        }
    }
}
