using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hemolink.Migrations
{
    public partial class Agenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "agenda",
                columns: table => new
                {
                    IdAgendamento = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Agendamento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Id_DoadorIdDoador = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agenda", x => x.IdAgendamento);
                    table.ForeignKey(
                        name: "FK_agenda_doador_Id_DoadorIdDoador",
                        column: x => x.Id_DoadorIdDoador,
                        principalTable: "doador",
                        principalColumn: "IdDoador",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_agenda_Id_DoadorIdDoador",
                table: "agenda",
                column: "Id_DoadorIdDoador");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "agenda");
        }
    }
}
