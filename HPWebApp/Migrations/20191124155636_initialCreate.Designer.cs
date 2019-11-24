﻿// <auto-generated />
using System;
using HPWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HPWebApp.Migrations
{
    [DbContext(typeof(HPContext))]
    [Migration("20191124155636_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("Propietario");
                });
#pragma warning restore 612, 618
        }
    }
}
