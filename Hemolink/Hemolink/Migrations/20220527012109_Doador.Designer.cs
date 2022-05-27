﻿// <auto-generated />
using System;
using Hemolink.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hemolink.Migrations
{
    [DbContext(typeof(_DbContext))]
    [Migration("20220527012109_Doador")]
    partial class Doador
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Hemolink.Models.Doador", b =>
                {
                    b.Property<int>("IdDoador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdDoador"));

                    b.Property<int>("CPF")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("DataNascimento")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

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

                    b.Property<string>("TipoSanguineo")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)");

                    b.Property<DateOnly>("UltimaDoacao")
                        .HasColumnType("date");

                    b.HasKey("IdDoador");

                    b.ToTable("doador");
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
#pragma warning restore 612, 618
        }
    }
}