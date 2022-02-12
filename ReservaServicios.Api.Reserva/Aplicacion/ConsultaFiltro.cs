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
    public class ConsultaFiltro
    {
        public class ReservaUnica : MediatR.IRequest<ReservaDocenteDto>
        {
            public Guid? ReservaDocenteId { get; set; }
        }

        public class Manejador : IRequestHandler<ReservaUnica, ReservaDocenteDto>
        {
            private readonly ContextoReserva _contexto;
            private readonly IMapper _mapper;
            public Manejador(ContextoReserva contexto,IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<ReservaDocenteDto> Handle(ReservaUnica request, CancellationToken cancellationToken)
            {
                var reserva = await _contexto.ReservaDocente.Where(x => x.ReservaDocenteId == request.ReservaDocenteId).FirstOrDefaultAsync();
                if(reserva == null)
                {
                    throw new Exception("No se encontro la Reserva");
                }
                var reservaDto = _mapper.Map<ReservaDocente, ReservaDocenteDto>(reserva);
                return reservaDto;
            }
        }
    }
}
