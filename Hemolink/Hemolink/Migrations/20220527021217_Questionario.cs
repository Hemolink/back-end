using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hemolink.Migrations
{
    public partial class Questionario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "questionario",
                columns: table => new
                {
                    IdFormulario = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_DoadorIdDoador = table.Column<int>(type: "integer", nullable: false),
                    DataPreenchimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BebidaAlcolica = table.Column<bool>(type: "boolean", nullable: false),
                    ResfriadoGripado = table.Column<bool>(type: "boolean", nullable: false),
                    Febre = table.Column<bool>(type: "boolean", nullable: false),
                    DorPeito = table.Column<bool>(type: "boolean", nullable: false),
                    DoencaCronica = table.Column<bool>(type: "boolean", nullable: false),
                    DoencaGrave = table.Column<string>(type: "text", nullable: false),
                    ExtracaoDentaria = table.Column<bool>(type: "boolean", nullable: false),
                    CirurgiaOdontologica = table.Column<bool>(type: "boolean", nullable: false),
                    RemedioControlado = table.Column<string>(type: "text", nullable: false),
                    Vacinou = table.Column<bool>(type: "boolean", nullable: false),
                    RecebeuTransfusao = table.Column<bool>(type: "boolean", nullable: false),
                    RecebeuPlasma = table.Column<bool>(type: "boolean", nullable: false),
                    RecebeuPlaquetas = table.Column<bool>(type: "boolean", nullable: false),
                    Tatuagem = table.Column<bool>(type: "boolean", nullable: false),
                    Piercing = table.Column<bool>(type: "boolean", nullable: false),
                    Acupuntura = table.Column<bool>(type: "boolean", nullable: false),
                    BioAcidente = table.Column<bool>(type: "boolean", nullable: false),
                    AnestesiaGeral = table.Column<bool>(type: "boolean", nullable: false),
                    JaOperado = table.Column<bool>(type: "boolean", nullable: false),
                    TransplanteOrgao = table.Column<bool>(type: "boolean", nullable: false),
                    ProcedimentoEndoscopico = table.Column<bool>(type: "boolean", nullable: false),
                    TesteHiv = table.Column<bool>(type: "boolean", nullable: false),
                    JaFoiPreso = table.Column<bool>(type: "boolean", nullable: false),
                    ViagemExterior = table.Column<bool>(type: "boolean", nullable: false),
                    Desmaio = table.Column<bool>(type: "boolean", nullable: false),
                    Convulsao = table.Column<bool>(type: "boolean", nullable: false),
                    AVC = table.Column<bool>(type: "boolean", nullable: false),
                    Derrame = table.Column<bool>(type: "boolean", nullable: false),
                    Dengue = table.Column<bool>(type: "boolean", nullable: false),
                    Zika = table.Column<bool>(type: "boolean", nullable: false),
                    Chikungunya = table.Column<bool>(type: "boolean", nullable: false),
                    Diabetes = table.Column<bool>(type: "boolean", nullable: false),
                    Hepatite = table.Column<bool>(type: "boolean", nullable: false),
                    IST = table.Column<bool>(type: "boolean", nullable: false),
                    Asma = table.Column<bool>(type: "boolean", nullable: false),
                    Bronquite = table.Column<bool>(type: "boolean", nullable: false),
                    Alergia = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ChoqueAnafilatico = table.Column<bool>(type: "boolean", nullable: false),
                    Cancer = table.Column<bool>(type: "boolean", nullable: false),
                    Tumor = table.Column<bool>(type: "boolean", nullable: false),
                    Leucemia = table.Column<bool>(type: "boolean", nullable: false),
                    VacaLouca = table.Column<bool>(type: "boolean", nullable: false),
                    Ferida = table.Column<bool>(type: "boolean", nullable: false),
                    Coceira = table.Column<bool>(type: "boolean", nullable: false),
                    DrogasIlicitas = table.Column<bool>(type: "boolean", nullable: false),
                    SexoSemProtecao = table.Column<bool>(type: "boolean", nullable: false),
                    SexualmenteAtivo = table.Column<bool>(type: "boolean", nullable: false),
                    SexoPago = table.Column<bool>(type: "boolean", nullable: false),
                    ParceirosSexuais = table.Column<int>(type: "integer", nullable: false),
                    RelacaoCasaMassagem = table.Column<bool>(type: "boolean", nullable: false),
                    RelacaoCasaSwing = table.Column<bool>(type: "boolean", nullable: false),
                    RelacaoCasaProstituicao = table.Column<bool>(type: "boolean", nullable: false),
                    SexoEntreHomens = table.Column<bool>(type: "boolean", nullable: false),
                    RelacaoHomemHomem = table.Column<bool>(type: "boolean", nullable: false),
                    Gravida = table.Column<bool>(type: "boolean", nullable: false),
                    Gravidezes = table.Column<int>(type: "integer", nullable: false),
                    Parto = table.Column<bool>(type: "boolean", nullable: false),
                    Aborto = table.Column<bool>(type: "boolean", nullable: false),
                    Amamentando = table.Column<bool>(type: "boolean", nullable: false),
                    Fuma = table.Column<bool>(type: "boolean", nullable: false),
                    SuspeitaCovid = table.Column<bool>(type: "boolean", nullable: false),
                    Observacoes = table.Column<bool>(type: "boolean", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionario", x => x.IdFormulario);
                    table.ForeignKey(
                        name: "FK_questionario_doador_Id_DoadorIdDoador",
                        column: x => x.Id_DoadorIdDoador,
                        principalTable: "doador",
                        principalColumn: "IdDoador",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_questionario_Id_DoadorIdDoador",
                table: "questionario",
                column: "Id_DoadorIdDoador");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "questionario");
        }
    }
}
