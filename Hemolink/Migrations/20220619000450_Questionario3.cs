using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hemolink.Migrations
{
    public partial class Questionario3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Observacoes",
                table: "questionario",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldMaxLength: 500);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Observacoes",
                table: "questionario",
                type: "boolean",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500);
        }
    }
}
