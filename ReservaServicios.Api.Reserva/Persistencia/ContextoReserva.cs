using Microsoft.EntityFrameworkCore;
using ReservaServicios.Api.Reserva.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaServicios.Api.Reserva.Persistencia
{
    public class ContextoReserva : DbContext
    {
        public ContextoReserva(DbContextOptions<ContextoReserva> options) : base(options) { }
        public DbSet<ReservaDocente> ReservaDocente { get; set; }
    }
}
