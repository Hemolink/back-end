﻿// <auto-generated />
using System;
using Hemolink.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hemolink.Migrations
{
    [DbContext(typeof(_DbContext))]
    [Migration("20220530231255_Agenda")]
    partial class Agenda
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Hemolink.Models.Agenda", b =>
                {
                    b.Property<int>("IdAgendamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdAgendamento"));

                    b.Property<DateTime>("Agendamento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DoadorId")
                        .HasColumnType("integer");

                    b.HasKey("IdAgendamento");

                    b.HasIndex("DoadorId");

                    b.ToTable("agenda");
                });

            modelBuilder.Entity("Hemolink.Models.Doador", b =>
                {
                    b.Property<int>("IdDoador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdDoador"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.Property<string>("SangueId")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UltimaDoacao")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("IdDoador");

                    b.HasIndex("SangueId");

                    b.ToTable("doador");
                });

            modelBuilder.Entity("Hemolink.Models.Questionario", b =>
                {
                    b.Property<int>("IdFormulario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdFormulario"));

                    b.Property<bool>("AVC")
                        .HasColumnType("boolean");

                    b.Property<bool>("Aborto")
                        .HasColumnType("boolean");

                    b.Property<bool>("Acupuntura")
                        .HasColumnType("boolean");

                    b.Property<string>("Alergia")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("Amamentando")
                        .HasColumnType("boolean");

                    b.Property<bool>("AnestesiaGeral")
                        .HasColumnType("boolean");

                    b.Property<bool>("Asma")
                        .HasColumnType("boolean");

                    b.Property<bool>("BebidaAlcolica")
                        .HasColumnType("boolean");

                    b.Property<bool>("BioAcidente")
                        .HasColumnType("boolean");

                    b.Property<bool>("Bronquite")
                        .HasColumnType("boolean");

                    b.Property<bool>("Cancer")
                        .HasColumnType("boolean");

                    b.Property<bool>("Chikungunya")
                        .HasColumnType("boolean");

                    b.Property<bool>("ChoqueAnafilatico")
                        .HasColumnType("boolean");

                    b.Property<bool>("CirurgiaOdontologica")
                        .HasColumnType("boolean");

                    b.Property<bool>("Coceira")
                        .HasColumnType("boolean");

                    b.Property<bool>("Convulsao")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("DataPreenchimento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Dengue")
                        .HasColumnType("boolean");

                    b.Property<bool>("Derrame")
                        .HasColumnType("boolean");

                    b.Property<bool>("Desmaio")
                        .HasColumnType("boolean");

                    b.Property<bool>("Diabetes")
                        .HasColumnType("boolean");

                    b.Property<bool>("DoencaCronica")
                        .HasColumnType("boolean");

                    b.Property<string>("DoencaGrave")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("DorPeito")
                        .HasColumnType("boolean");

                    b.Property<bool>("DrogasIlicitas")
                        .HasColumnType("boolean");

                    b.Property<bool>("ExtracaoDentaria")
                        .HasColumnType("boolean");

                    b.Property<bool>("Febre")
                        .HasColumnType("boolean");

                    b.Property<bool>("Ferida")
                        .HasColumnType("boolean");

                    b.Property<bool>("Fuma")
                        .HasColumnType("boolean");

                    b.Property<bool>("Gravida")
                        .HasColumnType("boolean");

                    b.Property<int>("Gravidezes")
                        .HasColumnType("integer");

                    b.Property<bool>("Hepatite")
                        .HasColumnType("boolean");

                    b.Property<bool>("IST")
                        .HasColumnType("boolean");

                    b.Property<int>("Id_DoadorIdDoador")
                        .HasColumnType("integer");

                    b.Property<bool>("JaFoiPreso")
                        .HasColumnType("boolean");

                    b.Property<bool>("JaOperado")
                        .HasColumnType("boolean");

                    b.Property<bool>("Leucemia")
                        .HasColumnType("boolean");

                    b.Property<bool>("Observacoes")
                        .HasMaxLength(500)
                        .HasColumnType("boolean");

                    b.Property<int>("ParceirosSexuais")
                        .HasColumnType("integer");

                    b.Property<bool>("Parto")
                        .HasColumnType("boolean");

                    b.Property<bool>("Piercing")
                        .HasColumnType("boolean");

                    b.Property<bool>("ProcedimentoEndoscopico")
                        .HasColumnType("boolean");

                    b.Property<bool>("RecebeuPlaquetas")
                        .HasColumnType("boolean");

                    b.Property<bool>("RecebeuPlasma")
                        .HasColumnType("boolean");

                    b.Property<bool>("RecebeuTransfusao")
                        .HasColumnType("boolean");

                    b.Property<bool>("RelacaoCasaMassagem")
                        .HasColumnType("boolean");

                    b.Property<bool>("RelacaoCasaProstituicao")
                        .HasColumnType("boolean");

                    b.Property<bool>("RelacaoCasaSwing")
                        .HasColumnType("boolean");

                    b.Property<bool>("RelacaoHomemHomem")
                        .HasColumnType("boolean");

                    b.Property<string>("RemedioControlado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("ResfriadoGripado")
                        .HasColumnType("boolean");

                    b.Property<bool>("SexoEntreHomens")
                        .HasColumnType("boolean");

                    b.Property<bool>("SexoPago")
                        .HasColumnType("boolean");

                    b.Property<bool>("SexoSemProtecao")
                        .HasColumnType("boolean");

                    b.Property<bool>("SexualmenteAtivo")
                        .HasColumnType("boolean");

                    b.Property<bool>("SuspeitaCovid")
                        .HasColumnType("boolean");

                    b.Property<bool>("Tatuagem")
                        .HasColumnType("boolean");

                    b.Property<bool>("TesteHiv")
                        .HasColumnType("boolean");

                    b.Property<bool>("TransplanteOrgao")
                        .HasColumnType("boolean");

                    b.Property<bool>("Tumor")
                        .HasColumnType("boolean");

                    b.Property<bool>("VacaLouca")
                        .HasColumnType("boolean");

                    b.Property<bool>("Vacinou")
                        .HasColumnType("boolean");

                    b.Property<bool>("ViagemExterior")
                        .HasColumnType("boolean");

                    b.Property<bool>("Zika")
                        .HasColumnType("boolean");

                    b.HasKey("IdFormulario");

                    b.HasIndex("Id_DoadorIdDoador");

                    b.ToTable("questionario");
                });

            modelBuilder.Entity("Hemolink.Models.Sangue", b =>
                {
                    b.Property<string>("tipo")
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)");

                    b.Property<float>("nivel_atual")
                        .HasColumnType("real");

                    b.Property<bool>("prioritario")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ultima_atualizacao")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("tipo");

                    b.ToTable("sangues");
                });

            modelBuilder.Entity("Hemolink.Models.Agenda", b =>
                {
                    b.HasOne("Hemolink.Models.Doador", "Doador")
                        .WithMany()
                        .HasForeignKey("DoadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doador");
                });

            modelBuilder.Entity("Hemolink.Models.Doador", b =>
                {
                    b.HasOne("Hemolink.Models.Sangue", "Sangue")
                        .WithMany()
                        .HasForeignKey("SangueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sangue");
                });

            modelBuilder.Entity("Hemolink.Models.Questionario", b =>
                {
                    b.HasOne("Hemolink.Models.Doador", "Id_Doador")
                        .WithMany()
                        .HasForeignKey("Id_DoadorIdDoador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Id_Doador");
                });
#pragma warning restore 612, 618
        }
    }
}
