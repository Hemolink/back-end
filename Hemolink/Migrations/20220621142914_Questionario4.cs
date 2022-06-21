using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hemolink.Migrations
{
    public partial class Questionario4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AVC",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "Aborto",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "Acupuntura",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "Alergia",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "AnestesiaGeral",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "Asma",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "BioAcidente",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "Bronquite",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "Chikungunya",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "ChoqueAnafilatico",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "CirurgiaOdontologica",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "Coceira",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "Diabetes",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "DoencaCronica",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "DoencaGrave",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "ExtracaoDentaria",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "Ferida",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "Gravidezes",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "Hepatite",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "JaFoiPreso",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "JaOperado",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "Leucemia",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "Observacoes",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "ParceirosSexuais",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "Piercing",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "ProcedimentoEndoscopico",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "RecebeuPlaquetas",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "RecebeuPlasma",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "RecebeuTransfusao",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "RelacaoCasaMassagem",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "RelacaoCasaProstituicao",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "RelacaoCasaSwing",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "RelacaoHomemHomem",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "RemedioControlado",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "SexualmenteAtivo",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "Tatuagem",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "TransplanteOrgao",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "Tumor",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "VacaLouca",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "Vacinou",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "ViagemExterior",
                table: "questionario");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ultima_atualizacao",
                table: "sangues",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataPreenchimento",
                table: "questionario",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaDoacao",
                table: "doador",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "doador",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Agendamento",
                table: "agenda",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ultima_atualizacao",
                table: "sangues",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataPreenchimento",
                table: "questionario",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AddColumn<bool>(
                name: "AVC",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Aborto",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Acupuntura",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Alergia",
                table: "questionario",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "AnestesiaGeral",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Asma",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "BioAcidente",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Bronquite",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Chikungunya",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ChoqueAnafilatico",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CirurgiaOdontologica",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Coceira",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Diabetes",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DoencaCronica",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DoencaGrave",
                table: "questionario",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ExtracaoDentaria",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ferida",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Gravidezes",
                table: "questionario",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Hepatite",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "JaFoiPreso",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "JaOperado",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Leucemia",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Observacoes",
                table: "questionario",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ParceirosSexuais",
                table: "questionario",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Piercing",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProcedimentoEndoscopico",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RecebeuPlaquetas",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RecebeuPlasma",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RecebeuTransfusao",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RelacaoCasaMassagem",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RelacaoCasaProstituicao",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RelacaoCasaSwing",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RelacaoHomemHomem",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RemedioControlado",
                table: "questionario",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "SexualmenteAtivo",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Tatuagem",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TransplanteOrgao",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Tumor",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "VacaLouca",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Vacinou",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ViagemExterior",
                table: "questionario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaDoacao",
                table: "doador",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "doador",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Agendamento",
                table: "agenda",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");
        }
    }
}
