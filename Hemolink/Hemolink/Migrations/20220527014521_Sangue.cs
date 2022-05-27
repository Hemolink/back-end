using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hemolink.Migrations
{
    public partial class Sangue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoSanguineo",
                table: "doador");

            migrationBuilder.AddColumn<string>(
                name: "TipoSanguineotipo",
                table: "doador",
                type: "character varying(3)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_doador_TipoSanguineotipo",
                table: "doador",
                column: "TipoSanguineotipo");

            migrationBuilder.AddForeignKey(
                name: "FK_doador_sangues_TipoSanguineotipo",
                table: "doador",
                column: "TipoSanguineotipo",
                principalTable: "sangues",
                principalColumn: "tipo",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doador_sangues_TipoSanguineotipo",
                table: "doador");

            migrationBuilder.DropIndex(
                name: "IX_doador_TipoSanguineotipo",
                table: "doador");

            migrationBuilder.DropColumn(
                name: "TipoSanguineotipo",
                table: "doador");

            migrationBuilder.AddColumn<string>(
                name: "TipoSanguineo",
                table: "doador",
                type: "character varying(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "");
        }
    }
}
