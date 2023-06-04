﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Проект_Отлов_животных;

#nullable disable

namespace Проект_Отлов_животных.Migrations
{
    [DbContext(typeof(DB))]
    [Migration("20230604110532_ApplicationAndLocality")]
    partial class ApplicationAndLocality
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Проект_Отлов_животных.Models+Applications", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AnimalHabitat")
                        .HasColumnType("text");

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Kategory")
                        .HasColumnType("text");

                    b.Property<int>("LocalityId")
                        .HasColumnType("integer");

                    b.Property<bool?>("UrgencyOfExecution")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("LocalityId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("Проект_Отлов_животных.Models+Locality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Administration")
                        .HasColumnType("text");

                    b.Property<string>("Adress")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Locality");
                });

            modelBuilder.Entity("Проект_Отлов_животных.Models+User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Company")
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .HasColumnType("text");

                    b.Property<string>("OMS")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Проект_Отлов_животных.Models+Applications", b =>
                {
                    b.HasOne("Проект_Отлов_животных.Models+Locality", "Locality")
                        .WithMany("Applications")
                        .HasForeignKey("LocalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Locality");
                });

            modelBuilder.Entity("Проект_Отлов_животных.Models+Locality", b =>
                {
                    b.Navigation("Applications");
                });
#pragma warning restore 612, 618
        }
    }
}
