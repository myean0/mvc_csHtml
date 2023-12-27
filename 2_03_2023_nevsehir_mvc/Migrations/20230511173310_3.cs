using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2_03_2023_nevsehir_mvc.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_sliderEkle",
                table: "sliderEkle");

            migrationBuilder.RenameTable(
                name: "sliderEkle",
                newName: "sliderTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sliderTable",
                table: "sliderTable",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "gezilecekYerlerTable",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gYerAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gYerAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gYerResim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sehirId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gezilecekYerlerTable", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gezilecekYerlerTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sliderTable",
                table: "sliderTable");

            migrationBuilder.RenameTable(
                name: "sliderTable",
                newName: "sliderEkle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sliderEkle",
                table: "sliderEkle",
                column: "Id");
        }
    }
}
