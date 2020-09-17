using Microsoft.EntityFrameworkCore.Migrations;

namespace msaPhase2.Migrations
{
    public partial class InitailCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scoreboard",
                columns: table => new
                {
                    scoreboardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    playerX = table.Column<string>(nullable: true),
                    playerO = table.Column<string>(nullable: true),
                    winner = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scoreboard", x => x.scoreboardId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scoreboard");
        }
    }
}
