﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using pokemon001.Models;

namespace pokemon001.Migrations
{
    [DbContext(typeof(PokemonContext))]
    [Migration("20210518231749_MigracionPokemon")]
    partial class MigracionPokemon
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("PokemonTipo", b =>
                {
                    b.Property<int>("PokemonesId")
                        .HasColumnType("integer");

                    b.Property<int>("TiposId")
                        .HasColumnType("integer");

                    b.HasKey("PokemonesId", "TiposId");

                    b.HasIndex("TiposId");

                    b.ToTable("PokemonTipo");
                });

            modelBuilder.Entity("pokemon001.Models.Entrenador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Foto")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.Property<int?>("PuebloId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PuebloId");

                    b.ToTable("Entrenadores");
                });

            modelBuilder.Entity("pokemon001.Models.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Pokemones");
                });

            modelBuilder.Entity("pokemon001.Models.Pueblo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.Property<int>("RegionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Pueblos");
                });

            modelBuilder.Entity("pokemon001.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Regiones");
                });

            modelBuilder.Entity("pokemon001.Models.Tipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tipo");
                });

            modelBuilder.Entity("PokemonTipo", b =>
                {
                    b.HasOne("pokemon001.Models.Pokemon", null)
                        .WithMany()
                        .HasForeignKey("PokemonesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pokemon001.Models.Tipo", null)
                        .WithMany()
                        .HasForeignKey("TiposId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("pokemon001.Models.Entrenador", b =>
                {
                    b.HasOne("pokemon001.Models.Pueblo", "Pueblo")
                        .WithMany("Entrenadores")
                        .HasForeignKey("PuebloId");

                    b.Navigation("Pueblo");
                });

            modelBuilder.Entity("pokemon001.Models.Pueblo", b =>
                {
                    b.HasOne("pokemon001.Models.Region", "Region")
                        .WithMany("Pueblos")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("pokemon001.Models.Pueblo", b =>
                {
                    b.Navigation("Entrenadores");
                });

            modelBuilder.Entity("pokemon001.Models.Region", b =>
                {
                    b.Navigation("Pueblos");
                });
#pragma warning restore 612, 618
        }
    }
}
