using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hemolink.Migrations
{
    public partial class Questionario1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoadorIdDoador",
                table: "questionario",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_questionario_DoadorIdDoador",
                table: "questionario",
                column: "DoadorIdDoador");

            migrationBuilder.AddForeignKey(
                name: "FK_questionario_doador_DoadorIdDoador",
                table: "questionario",
                column: "DoadorIdDoador",
                principalTable: "doador",
                principalColumn: "IdDoador",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_questionario_doador_DoadorIdDoador",
                table: "questionario");

            migrationBuilder.DropIndex(
                name: "IX_questionario_DoadorIdDoador",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "DoadorIdDoador",
                table: "questionario");
        }
    }
}
