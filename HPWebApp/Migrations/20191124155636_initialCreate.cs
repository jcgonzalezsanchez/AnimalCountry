using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HPWebApp.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Propietario",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PrimerNombre = table.Column<string>(nullable: false),
                    SegundoNombre = table.Column<string>(nullable: true),
                    PrimerApellido = table.Column<string>(nullable: false),
                    SegundoApellido = table.Column<string>(nullable: true),
                    TipoIdentificacion = table.Column<string>(nullable: false),
                    Identificacion = table.Column<string>(nullable: false),
                    Ciudad = table.Column<string>(nullable: true),
                    Ocupacion = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Telefono1 = table.Column<string>(nullable: false),
                    Telefono2 = table.Column<string>(nullable: true),
                    Celular1 = table.Column<string>(nullable: false),
                    Celular2 = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Observacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietario", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Propietario");
        }
    }
}
