using MediatR;
using ReservaServicios.Api.Reserva.Modelo;
using ReservaServicios.Api.Reserva.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ReservaServicios.Api.Reserva.Aplicacion
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public string CodigoReserva { get; set; }
            public string GrupoAlumno { get; set; }
            public string Tema { get; set; }
            public Guid? CodigoTurno { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly ContextoReserva _contexto;
            public Manejador(ContextoReserva contexto)
            {
                _contexto = contexto;
            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var reserva = new ReservaDocente
                {
                    CodigoReserva = request.CodigoReserva,
                    GrupoAlumno = request.GrupoAlumno,
                    Tema = request.Tema,
                    CodigoTurno = request.CodigoTurno
                };
                _contexto.ReservaDocente.Add(reserva);
                var value = await _contexto.SaveChangesAsync();
                if(value > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo guardar la Reserva");
            }
        }
    }
}
