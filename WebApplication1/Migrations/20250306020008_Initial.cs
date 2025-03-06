using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OlympicSports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Game = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlympicSports", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "OlympicSports",
                columns: new[] { "Id", "Category", "CountryCode", "Game", "Name", "Sport" },
                values: new object[,]
                {
                    { 1, "Indoor", "ca", "Winter Olympics", "Canada", "Curling" },
                    { 2, "Indoor", "se", "Winter Olympics", "Sweden", "Curling" },
                    { 3, "Indoor", "gb", "Winter Olympics", "Great Britain", "Curling" },
                    { 4, "Outdoor", "jm", "Winter Olympics", "Jamaica", "Bobsleigh" },
                    { 5, "Outdoor", "it", "Winter Olympics", "Italy", "Bobsleigh" },
                    { 6, "Outdoor", "jp", "Winter Olympics", "Japan", "Bobsleigh" },
                    { 7, "Indoor", "de", "Summer Olympics", "Germany", "Diving" },
                    { 8, "Indoor", "cn", "Summer Olympics", "China", "Diving" },
                    { 9, "Indoor", "mx", "Summer Olympics", "Mexico", "Diving" },
                    { 10, "Outdoor", "br", "Summer Olympics", "Brazil", "Road Cycling" },
                    { 11, "Outdoor", "nl", "Summer Olympics", "Netherlands", "Cycling" },
                    { 12, "Outdoor", "us", "Summer Olympics", "USA", "Road Cycling" },
                    { 13, "Indoor", "th", "Paralympics", "Thailand", "Archery" },
                    { 14, "Indoor", "uy", "Paralympics", "Uruguay", "Archery" },
                    { 15, "Indoor", "ua", "Paralympics", "Ukraine", "Archery" },
                    { 16, "Outdoor", "at", "Paralympics", "Austria", "Canoe Sprint" },
                    { 17, "Outdoor", "pk", "Paralympics", "Pakistan", "Canoe Sprint" },
                    { 18, "Outdoor", "zw", "Paralympics", "Zimbabwe", "Canoe Sprint" },
                    { 19, "Indoor", "fr", "Youth Olympic Games", "France", "Breakdancing" },
                    { 20, "Indoor", "cy", "Youth Olympic Games", "Cyprus", "Breakdancing" },
                    { 21, "Indoor", "ru", "Youth Olympic Games", "Russia", "Breakdancing" },
                    { 22, "Outdoor", "fi", "Youth Olympic Games", "Finland", "Skateboarding" },
                    { 23, "Outdoor", "sk", "Youth Olympic Games", "Slovakia", "Skateboarding" },
                    { 24, "Outdoor", "pt", "Youth Olympic Games", "Portugal", "Skateboarding" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OlympicSports");
        }
    }
}
