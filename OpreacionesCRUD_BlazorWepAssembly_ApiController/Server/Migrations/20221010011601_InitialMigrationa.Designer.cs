﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpreacionesCRUD_BlazorWepAssembly_ApiController.Server;

#nullable disable

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Server.Migrations
{
    [DbContext(typeof(ApplicationsDBContext))]
    [Migration("20221010011601_InitialMigrationa")]
    partial class InitialMigrationa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos.CarreraEstudiante", b =>
                {
                    b.Property<int>("IdCarrera")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCarrera"), 1L, 1);

                    b.Property<string>("CodigoCarrera")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NombreCarrera")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UsuariosId")
                        .HasColumnType("int");

                    b.HasKey("IdCarrera");

                    b.HasIndex("UsuariosId");

                    b.ToTable("_carreraEstudiante");
                });

            modelBuilder.Entity("OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos.CarrerasTotalesUni", b =>
                {
                    b.Property<int>("IdCarrera")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCarrera"), 1L, 1);

                    b.Property<string>("CodigoCarrera")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NombreCarrera")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdCarrera");

                    b.ToTable("_carrerasTotalesUnis");
                });

            modelBuilder.Entity("OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos.MateriasEstudiante", b =>
                {
                    b.Property<int>("IdMaterias")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMaterias"), 1L, 1);

                    b.Property<string>("NombresMaterias")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("UsuariosId")
                        .HasColumnType("int");

                    b.HasKey("IdMaterias");

                    b.HasIndex("UsuariosId");

                    b.ToTable("_materiasEstudiante");
                });

            modelBuilder.Entity("OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos.MateriasTotalesUni", b =>
                {
                    b.Property<int>("IdMaterias")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMaterias"), 1L, 1);

                    b.Property<string>("NombresMaterias")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("IdMaterias");

                    b.ToTable("_materiasTotalesUni");
                });

            modelBuilder.Entity("OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Cuatrimestre")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Roles")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("_usuarios");
                });

            modelBuilder.Entity("OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos.CarreraEstudiante", b =>
                {
                    b.HasOne("OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos.Usuarios", null)
                        .WithMany("CarreraEstudianteList")
                        .HasForeignKey("UsuariosId");
                });

            modelBuilder.Entity("OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos.MateriasEstudiante", b =>
                {
                    b.HasOne("OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos.Usuarios", null)
                        .WithMany("MateriasEstudianteList")
                        .HasForeignKey("UsuariosId");
                });

            modelBuilder.Entity("OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos.Usuarios", b =>
                {
                    b.Navigation("CarreraEstudianteList");

                    b.Navigation("MateriasEstudianteList");
                });
#pragma warning restore 612, 618
        }
    }
}
