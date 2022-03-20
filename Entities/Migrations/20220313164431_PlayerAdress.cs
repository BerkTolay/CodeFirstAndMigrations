using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class PlayerAdress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerAdresses",
                columns: table => new
                {
                    PlayerAdressId = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<int>(type: "int", nullable: false),
                    PostCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerAdresses", x => x.PlayerAdressId);
                    table.ForeignKey(
                        name: "FK_PlayerAdresses_Players_PlayerAdressId",
                        column: x => x.PlayerAdressId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerAdresses");
        }
    }
}
