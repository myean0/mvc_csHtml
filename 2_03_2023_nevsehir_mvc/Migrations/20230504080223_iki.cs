using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2_03_2023_nevsehir_mvc.Migrations
{
    public partial class iki : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "sehirId",
                table: "sliderEkle",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sehirId",
                table: "sliderEkle");
        }
    }
}
