using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hemolink.Migrations
{
    public partial class Doador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaDoacao",
                table: "doador",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "doador",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddColumn<string>(
                name: "SangueId",
                table: "doador",
                type: "character varying(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_doador_SangueId",
                table: "doador",
                column: "SangueId");

            migrationBuilder.AddForeignKey(
                name: "FK_doador_sangues_SangueId",
                table: "doador",
                column: "SangueId",
                principalTable: "sangues",
                principalColumn: "tipo",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doador_sangues_SangueId",
                table: "doador");

            migrationBuilder.DropIndex(
                name: "IX_doador_SangueId",
                table: "doador");

            migrationBuilder.DropColumn(
                name: "SangueId",
                table: "doador");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "UltimaDoacao",
                table: "doador",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DataNascimento",
                table: "doador",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

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
    }
}
