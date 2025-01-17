﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestionSoutenances.Migrations
{
    [DbContext(typeof(GestionSoutenancesContext))]
    [Migration("20231226185450_mg5")]
    partial class mg5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GestionSoutenances.Models.Enseignant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Enseignant");
                });

            modelBuilder.Entity("GestionSoutenances.Models.Etudiant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DateNaiss")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Etudiant");
                });

            modelBuilder.Entity("GestionSoutenances.Models.PFE", b =>
                {
                    b.Property<int>("PFEID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PFEID"));

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateFin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EncadrantID")
                        .HasColumnType("int");

                    b.Property<int>("SocieteID")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("PFEID");

                    b.HasIndex("EncadrantID");

                    b.HasIndex("SocieteID");

                    b.ToTable("PFE");
                });

            modelBuilder.Entity("GestionSoutenances.Models.PFE_Etudiant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("EtudiantID")
                        .HasColumnType("int");

                    b.Property<int>("PFEID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EtudiantID");

                    b.HasIndex("PFEID");

                    b.ToTable("PFE_Etudiant");
                });

            modelBuilder.Entity("GestionSoutenances.Models.Societe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lib")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Societe");
                });

            modelBuilder.Entity("GestionSoutenances.Models.PFE", b =>
                {
                    b.HasOne("GestionSoutenances.Models.Enseignant", "Encadrant")
                        .WithMany()
                        .HasForeignKey("EncadrantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestionSoutenances.Models.Societe", "Societe")
                        .WithMany()
                        .HasForeignKey("SocieteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Encadrant");

                    b.Navigation("Societe");
                });

            modelBuilder.Entity("GestionSoutenances.Models.PFE_Etudiant", b =>
                {
                    b.HasOne("GestionSoutenances.Models.Etudiant", "Etudiant")
                        .WithMany()
                        .HasForeignKey("EtudiantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestionSoutenances.Models.PFE", "PFE")
                        .WithMany("PFE_Etudiant")
                        .HasForeignKey("PFEID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Etudiant");

                    b.Navigation("PFE");
                });

            modelBuilder.Entity("GestionSoutenances.Models.PFE", b =>
                {
                    b.Navigation("PFE_Etudiant");
                });
#pragma warning restore 612, 618
        }
    }
}
