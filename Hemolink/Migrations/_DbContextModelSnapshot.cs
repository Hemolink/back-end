﻿// <auto-generated />
using System;
using Hemolink.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hemolink.Migrations
{
    [DbContext(typeof(_DbContext))]
    partial class _DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("timestamp without time zone");

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
                        .HasColumnType("timestamp without time zone");

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
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("IdDoador");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("SangueId");

                    b.ToTable("doador");
                });

            modelBuilder.Entity("Hemolink.Models.Questionario", b =>
                {
                    b.Property<int>("IdFormulario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdFormulario"));

                    b.Property<bool>("Amamentando")
                        .HasColumnType("boolean");

                    b.Property<bool>("BebidaAlcolica")
                        .HasColumnType("boolean");

                    b.Property<bool>("Cancer")
                        .HasColumnType("boolean");

                    b.Property<bool>("Convulsao")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("DataPreenchimento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Dengue")
                        .HasColumnType("boolean");

                    b.Property<bool>("Derrame")
                        .HasColumnType("boolean");

                    b.Property<bool>("Desmaio")
                        .HasColumnType("boolean");

                    b.Property<int>("DoadorIdDoador")
                        .HasColumnType("integer");

                    b.Property<bool>("DorPeito")
                        .HasColumnType("boolean");

                    b.Property<bool>("DrogasIlicitas")
                        .HasColumnType("boolean");

                    b.Property<bool>("Febre")
                        .HasColumnType("boolean");

                    b.Property<bool>("Fuma")
                        .HasColumnType("boolean");

                    b.Property<bool>("Gravida")
                        .HasColumnType("boolean");

                    b.Property<bool>("IST")
                        .HasColumnType("boolean");

                    b.Property<int>("Id_Doador")
                        .HasColumnType("integer");

                    b.Property<bool>("Parto")
                        .HasColumnType("boolean");

                    b.Property<bool>("ResfriadoGripado")
                        .HasColumnType("boolean");

                    b.Property<bool>("SexoEntreHomens")
                        .HasColumnType("boolean");

                    b.Property<bool>("SexoPago")
                        .HasColumnType("boolean");

                    b.Property<bool>("SexoSemProtecao")
                        .HasColumnType("boolean");

                    b.Property<bool>("SuspeitaCovid")
                        .HasColumnType("boolean");

                    b.Property<bool>("TesteHiv")
                        .HasColumnType("boolean");

                    b.Property<bool>("Zika")
                        .HasColumnType("boolean");

                    b.HasKey("IdFormulario");

                    b.HasIndex("DoadorIdDoador");

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
                        .HasColumnType("timestamp without time zone");

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
                    b.HasOne("Hemolink.Models.Doador", "Doador")
                        .WithMany()
                        .HasForeignKey("DoadorIdDoador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doador");
                });
#pragma warning restore 612, 618
        }
    }
}
