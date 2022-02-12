using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ReservaServicios.Api.Reserva.Modelo;
using ReservaServicios.Api.Reserva.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ReservaServicios.Api.Reserva.Aplicacion
{
    public class Consulta
    {
        public class Ejecuta : IRequest<List<ReservaDocenteDto>> { }
        public class Manejador : IRequestHandler<Ejecuta, List<ReservaDocenteDto>>
        {
            private readonly ContextoReserva _contexto;
            private readonly IMapper _mapper;
            public Manejador(ContextoReserva contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<List<ReservaDocenteDto>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var reservas = await _contexto.ReservaDocente.ToListAsync();
                var reservasDto = _mapper.Map<List<ReservaDocente>, List<ReservaDocenteDto>>(reservas);
                return reservasDto;
            }
        }
    }
}
