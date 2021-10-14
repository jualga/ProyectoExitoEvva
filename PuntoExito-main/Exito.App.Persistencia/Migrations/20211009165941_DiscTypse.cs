using Microsoft.EntityFrameworkCore.Migrations;

namespace Exito.App.Persistencia.Migrations
{
    public partial class DiscTypse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypoDisco",
                table: "Consolas");

            migrationBuilder.AddColumn<int>(
                name: "TypoDiscoId",
                table: "Consolas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TypoDiscos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypoDiscos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consolas_TypoDiscoId",
                table: "Consolas",
                column: "TypoDiscoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consolas_TypoDiscos_TypoDiscoId",
                table: "Consolas",
                column: "TypoDiscoId",
                principalTable: "TypoDiscos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consolas_TypoDiscos_TypoDiscoId",
                table: "Consolas");

            migrationBuilder.DropTable(
                name: "TypoDiscos");

            migrationBuilder.DropIndex(
                name: "IX_Consolas_TypoDiscoId",
                table: "Consolas");

            migrationBuilder.DropColumn(
                name: "TypoDiscoId",
                table: "Consolas");

            migrationBuilder.AddColumn<int>(
                name: "TypoDisco",
                table: "Consolas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
