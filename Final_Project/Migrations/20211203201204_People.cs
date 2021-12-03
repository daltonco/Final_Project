using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Migrations
{
    public partial class People : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Birthday = table.Column<string>(nullable: true),
                    Major = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentInfo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "StudentInfo",
                columns: new[] { "Id", "Birthday", "FirstName", "LastName", "Major", "Year" },
                values: new object[,]
                {
                    { 1, "6-20-200", "David", "Draginoff", "IT CyberSecurity", "junior" },
                    { 2, "4-4-1999", "Colton", "Dalton", "IT Software Dev", "junior" },
                    { 3, "3-18-2000", "Alex", "Gajic", "IT ", "Senior" },
                    { 4, "5-1-2001", "Samuel", "Untener", "IT Game Development and Simulation", "junior" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentInfo");
        }
    }
}
