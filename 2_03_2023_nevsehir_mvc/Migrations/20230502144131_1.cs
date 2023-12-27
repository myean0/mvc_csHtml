using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2_03_2023_nevsehir_mvc.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sehirTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SehirAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AltBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sehirTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sliderEkle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SliderResim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SliderBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SliderAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sliderEkle", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sehirTable");

            migrationBuilder.DropTable(
                name: "sliderEkle");
        }
    }
}
