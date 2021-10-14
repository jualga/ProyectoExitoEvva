using Microsoft.EntityFrameworkCore.Migrations;

namespace Exito.App.Persistencia.Migrations
{
    public partial class ProCodigo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "VideoJuegos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Controles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Consolas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "VideoJuegos");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Controles");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Consolas");
        }
    }
}
