using AutoMapper;
using ReservaServicios.Api.Reserva.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaServicios.Api.Reserva.Aplicacion
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ReservaDocente, ReservaDocenteDto>();
        }
    }
}
