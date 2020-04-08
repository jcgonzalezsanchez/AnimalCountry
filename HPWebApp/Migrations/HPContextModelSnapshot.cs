﻿// <auto-generated />
using System;
using HPWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HPWebApp.Migrations
{
    [DbContext(typeof(HPContext))]
    partial class HPContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HPWebApp.Models.Paciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Chip");

                    b.Property<string>("Color");

                    b.Property<DateTime?>("FechaDefuncion");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("MotivoDefuncion");

                    b.Property<string>("Nombre");

                    b.Property<string>("NumeroChip");

                    b.Property<string>("Observacion");

                    b.Property<Guid>("PropietarioId");

                    b.Property<string>("SenasParticulares");

                    b.Property<string>("Zona");

                    b.HasKey("Id");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("HPWebApp.Models.Propietario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Celular1")
                        .IsRequired();

                    b.Property<string>("Celular2");

                    b.Property<string>("Ciudad");

                    b.Property<string>("Correo");

                    b.Property<string>("Direccion");

                    b.Property<string>("Identificacion")
                        .IsRequired();

                    b.Property<string>("Observacion");

                    b.Property<string>("Ocupacion");

                    b.Property<string>("PrimerApellido")
                        .IsRequired();

                    b.Property<string>("PrimerNombre")
                        .IsRequired();

                    b.Property<string>("SegundoApellido");

                    b.Property<string>("SegundoNombre");

                    b.Property<string>("Telefono1")
                        .IsRequired();

                    b.Property<string>("Telefono2");

                    b.Property<string>("TipoIdentificacion")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Propietarios");
                });

            modelBuilder.Entity("HPWebApp.Models.PropietarioPaciente", b =>
                {
                    b.Property<Guid>("PacienteId");

                    b.Property<Guid>("PropietarioId");

                    b.HasKey("PacienteId", "PropietarioId");

                    b.HasIndex("PropietarioId");

                    b.ToTable("PropietarioPacientes");
                });

            modelBuilder.Entity("HPWebApp.Models.PropietarioPaciente", b =>
                {
                    b.HasOne("HPWebApp.Models.Paciente", "Paciente")
                        .WithMany("PropietarioPacientes")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HPWebApp.Models.Propietario", "Propietario")
                        .WithMany("PropietarioPacientes")
                        .HasForeignKey("PropietarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
