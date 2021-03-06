// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReservaServicios.Api.Reserva.Persistencia;

namespace ReservaServicios.Api.Reserva.Migrations
{
    [DbContext(typeof(ContextoReserva))]
    partial class ContextoReservaModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReservaServicios.Api.Reserva.Modelo.ReservaDocente", b =>
                {
                    b.Property<Guid?>("ReservaDocenteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoReserva")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CodigoTurno")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GrupoAlumno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReservaIdGuid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tema")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReservaDocenteId");

                    b.ToTable("ReservaDocente");
                });
#pragma warning restore 612, 618
        }
    }
}
