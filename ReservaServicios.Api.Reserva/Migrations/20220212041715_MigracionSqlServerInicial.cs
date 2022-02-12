using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservaServicios.Api.Reserva.Migrations
{
    public partial class MigracionSqlServerInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReservaDocente",
                columns: table => new
                {
                    ReservaDocenteId = table.Column<Guid>(nullable: false),
                    CodigoReserva = table.Column<string>(nullable: true),
                    GrupoAlumno = table.Column<string>(nullable: true),
                    Tema = table.Column<string>(nullable: true),
                    ReservaIdGuid = table.Column<string>(nullable: true),
                    CodigoTurno = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservaDocente", x => x.ReservaDocenteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservaDocente");
        }
    }
}
