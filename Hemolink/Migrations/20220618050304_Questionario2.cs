using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hemolink.Migrations
{
    public partial class Questionario2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_questionario_doador_Id_DoadorIdDoador",
                table: "questionario");

            migrationBuilder.DropIndex(
                name: "IX_questionario_Id_DoadorIdDoador",
                table: "questionario");

            migrationBuilder.RenameColumn(
                name: "Id_DoadorIdDoador",
                table: "questionario",
                newName: "Id_Doador");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id_Doador",
                table: "questionario",
                newName: "Id_DoadorIdDoador");

            migrationBuilder.CreateIndex(
                name: "IX_questionario_Id_DoadorIdDoador",
                table: "questionario",
                column: "Id_DoadorIdDoador");

            migrationBuilder.AddForeignKey(
                name: "FK_questionario_doador_Id_DoadorIdDoador",
                table: "questionario",
                column: "Id_DoadorIdDoador",
                principalTable: "doador",
                principalColumn: "IdDoador",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
