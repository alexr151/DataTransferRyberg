using Microsoft.EntityFrameworkCore.Migrations;

namespace DataTransferRyberg.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    SportId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.SportId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SportId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LogoImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                    table.ForeignKey(
                        name: "FK_Countries_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_Sports_SportId",
                        column: x => x.SportId,
                        principalTable: "Sports",
                        principalColumn: "SportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Name" },
                values: new object[,]
                {
                    { "wo", "Winter Olympic Games" },
                    { "so", "Summer Olympic Games" },
                    { "po", "Paralympic Games" },
                    { "yo", "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "SportId", "Name", "Type" },
                values: new object[,]
                {
                    { "curl", "Curling", "Indoor" },
                    { "bob", "Bobsleigh", "Outdoor" },
                    { "div", "Diving", "Indoor" },
                    { "cycl", "Road Cycling", "Outdoor" },
                    { "arch", "Archery", "Indoor" },
                    { "cs", "Canoe Sprint", "Outdoor" },
                    { "break", "Breakdancing", "Indoor" },
                    { "skate", "Skateboarding", "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "GameId", "LogoImage", "Name", "SportId" },
                values: new object[,]
                {
                    { "CAN", "wo", "can.png", "Canada", "curl" },
                    { "fin", "yo", "fin.png", "Finland", "skate" },
                    { "rus", "yo", "rus.png", "Russia", "break" },
                    { "cyp", "yo", "cyp.png", "Cyprus", "break" },
                    { "fran", "yo", "fran.png", "France", "break" },
                    { "zim", "po", "zim.png", "Zimbabwe", "cs" },
                    { "pak", "po", "pak.png", "Pakistan", "cs" },
                    { "AUS", "po", "aus.png", "Austria", "cs" },
                    { "UKR", "po", "ukr.png", "Ukraine", "arch" },
                    { "URA", "po", "ura.png", "Uruguay", "arch" },
                    { "THA", "po", "tha.png", "Thailand", "arch" },
                    { "USA", "so", "usa.png", "United States of America", "cycl" },
                    { "NET", "so", "net.png", "Netherlands", "cycl" },
                    { "BRZ", "so", "brz.png", "Brazil", "cycl" },
                    { "MEX", "so", "mex.png", "Mexico", "div" },
                    { "CHI", "so", "chi.png", "China", "div" },
                    { "GER", "so", "ger.png", "Germany", "div" },
                    { "JAP", "wo", "jap.png", "Japan", "bob" },
                    { "ITL", "wo", "itl.png", "Italy", "bob" },
                    { "JAM", "wo", "jam.png", "Jamaica", "bob" },
                    { "GB", "wo", "gb.png", "Great Britain", "curl" },
                    { "SWE", "wo", "swe.png", "Sweden", "curl" },
                    { "slov", "yo", "slov.png", "Slovakia", "skate" },
                    { "port", "yo", "port.png", "Portugal", "skate" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameId",
                table: "Countries",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_SportId",
                table: "Countries",
                column: "SportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Sports");
        }
    }
}
