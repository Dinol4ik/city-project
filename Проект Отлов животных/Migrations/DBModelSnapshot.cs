﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Проект_Отлов_животных;

#nullable disable

namespace Проект_Отлов_животных.Migrations
{
    [DbContext(typeof(DB))]
    partial class DBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Проект_Отлов_животных.Models+Act_Of_Capture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long?>("Act_Number")
                        .HasColumnType("bigint");

                    b.Property<string>("Amount_Of_Animals")
                        .HasColumnType("text");

                    b.Property<string>("Amount_Of_Cats")
                        .HasColumnType("text");

                    b.Property<string>("Amount_Of_Dogs")
                        .HasColumnType("text");

                    b.Property<int>("ApplicationId")
                        .HasColumnType("integer");

                    b.Property<string>("Date_Of_Capture")
                        .HasColumnType("text");

                    b.Property<int>("Municipal_ContractId")
                        .HasColumnType("integer");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("integer");

                    b.Property<string>("Target")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("Municipal_ContractId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("act_Of_Captures");
                });

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

                    b.Property<int?>("number")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LocalityId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("Проект_Отлов_животных.Models+Card_Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ApplicationId")
                        .HasColumnType("integer");

                    b.Property<string>("Breed")
                        .HasColumnType("text");

                    b.Property<string>("Chip_number")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Ears")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("Indentification_label")
                        .HasColumnType("text");

                    b.Property<long?>("Kategory")
                        .HasColumnType("bigint");

                    b.Property<int>("LocalityId")
                        .HasColumnType("integer");

                    b.Property<string>("Special_signs")
                        .HasColumnType("text");

                    b.Property<string>("Tail")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("LocalityId");

                    b.ToTable("card_Animals");
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

            modelBuilder.Entity("Проект_Отлов_животных.Models+Municipal_contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Date_Of_Action")
                        .HasColumnType("text");

                    b.Property<string>("Date_Of_Conclusion")
                        .HasColumnType("text");

                    b.Property<long?>("Number")
                        .HasColumnType("bigint");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("municipal_Contracts");
                });

            modelBuilder.Entity("Проект_Отлов_животных.Models+Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("INN")
                        .HasColumnType("text");

                    b.Property<string>("KPP")
                        .HasColumnType("text");

                    b.Property<int>("LocalityId")
                        .HasColumnType("integer");

                    b.Property<string>("Registation_addres")
                        .HasColumnType("text");

                    b.Property<string>("Sole_Properietor")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("TypeOfId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LocalityId");

                    b.HasIndex("TypeOfId");

                    b.ToTable("organizations");
                });

            modelBuilder.Entity("Проект_Отлов_животных.Models+Type_Of_Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("type_Of_Organizations");
                });

            modelBuilder.Entity("Проект_Отлов_животных.Models+User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Login")
                        .HasColumnType("text");

                    b.Property<int?>("OrganizationId")
                        .HasColumnType("integer");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Проект_Отлов_животных.Models+Act_Of_Capture", b =>
                {
                    b.HasOne("Проект_Отлов_животных.Models+Applications", "Application")
                        .WithMany("act_Of_Captures")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Проект_Отлов_животных.Models+Municipal_contract", "Municipal_Contract")
                        .WithMany("act_Of_Captures")
                        .HasForeignKey("Municipal_ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Проект_Отлов_животных.Models+Organization", "Organization")
                        .WithMany("act_Of_Captures")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");

                    b.Navigation("Municipal_Contract");

                    b.Navigation("Organization");
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

            modelBuilder.Entity("Проект_Отлов_животных.Models+Card_Animal", b =>
                {
                    b.HasOne("Проект_Отлов_животных.Models+Applications", "Application")
                        .WithMany("card_Animals")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Проект_Отлов_животных.Models+Locality", "Locality")
                        .WithMany("card_Animals")
                        .HasForeignKey("LocalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");

                    b.Navigation("Locality");
                });

            modelBuilder.Entity("Проект_Отлов_животных.Models+Municipal_contract", b =>
                {
                    b.HasOne("Проект_Отлов_животных.Models+Organization", "Organization")
                        .WithMany("Municipal_contracts")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Проект_Отлов_животных.Models+Organization", b =>
                {
                    b.HasOne("Проект_Отлов_животных.Models+Locality", "Locality")
                        .WithMany()
                        .HasForeignKey("LocalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Проект_Отлов_животных.Models+Type_Of_Organization", "TypeOf")
                        .WithMany("Organizations")
                        .HasForeignKey("TypeOfId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Locality");

                    b.Navigation("TypeOf");
                });

            modelBuilder.Entity("Проект_Отлов_животных.Models+User", b =>
                {
                    b.HasOne("Проект_Отлов_животных.Models+Organization", "Organization")
                        .WithMany("users")
                        .HasForeignKey("OrganizationId");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Проект_Отлов_животных.Models+Applications", b =>
                {
                    b.Navigation("act_Of_Captures");

                    b.Navigation("card_Animals");
                });

            modelBuilder.Entity("Проект_Отлов_животных.Models+Locality", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("card_Animals");
                });

            modelBuilder.Entity("Проект_Отлов_животных.Models+Municipal_contract", b =>
                {
                    b.Navigation("act_Of_Captures");
                });

            modelBuilder.Entity("Проект_Отлов_животных.Models+Organization", b =>
                {
                    b.Navigation("Municipal_contracts");

                    b.Navigation("act_Of_Captures");

                    b.Navigation("users");
                });

            modelBuilder.Entity("Проект_Отлов_животных.Models+Type_Of_Organization", b =>
                {
                    b.Navigation("Organizations");
                });
#pragma warning restore 612, 618
        }
    }
}
