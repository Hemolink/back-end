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
    [Migration("20220522202233_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

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
