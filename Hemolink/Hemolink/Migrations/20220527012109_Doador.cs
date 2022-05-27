using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hemolink.Migrations
{
    public partial class Doador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "doador",
                columns: table => new
                {
                    IdDoador = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Sobrenome = table.Column<string>(type: "text", nullable: false),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Senha = table.Column<string>(type: "text", nullable: false),
                    TipoSanguineo = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    CPF = table.Column<int>(type: "integer", nullable: false),
                    UltimaDoacao = table.Column<DateOnly>(type: "date", nullable: false),
                    Sexo = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doador", x => x.IdDoador);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "doador");
        }
    }
}
