using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hemolink.Migrations
{
    public partial class Agenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_agenda_doador_Id_DoadorIdDoador",
                table: "agenda");

            migrationBuilder.RenameColumn(
                name: "Id_DoadorIdDoador",
                table: "agenda",
                newName: "DoadorId");

            migrationBuilder.RenameIndex(
                name: "IX_agenda_Id_DoadorIdDoador",
                table: "agenda",
                newName: "IX_agenda_DoadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_agenda_doador_DoadorId",
                table: "agenda",
                column: "DoadorId",
                principalTable: "doador",
                principalColumn: "IdDoador",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_agenda_doador_DoadorId",
                table: "agenda");

            migrationBuilder.RenameColumn(
                name: "DoadorId",
                table: "agenda",
                newName: "Id_DoadorIdDoador");

            migrationBuilder.RenameIndex(
                name: "IX_agenda_DoadorId",
                table: "agenda",
                newName: "IX_agenda_Id_DoadorIdDoador");

            migrationBuilder.AddForeignKey(
                name: "FK_agenda_doador_Id_DoadorIdDoador",
                table: "agenda",
                column: "Id_DoadorIdDoador",
                principalTable: "doador",
                principalColumn: "IdDoador",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
