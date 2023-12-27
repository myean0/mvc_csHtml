using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2_03_2023_nevsehir_mvc.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "detayResim",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    detayResimYolu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sehirId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detayResim", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detayResim");
        }
    }
}
