using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hemolink.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sangues",
                columns: table => new
                {
                    tipo = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    nivel_atual = table.Column<float>(type: "real", nullable: false),
                    prioritario = table.Column<bool>(type: "boolean", nullable: false),
                    ultima_atualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sangues", x => x.tipo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sangues");
        }
    }
}
