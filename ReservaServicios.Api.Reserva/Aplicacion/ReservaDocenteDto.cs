using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaServicios.Api.Reserva.Aplicacion
{
    public class ReservaDocenteDto
    {
        public Guid? ReservaDocenteId { get; set; }
        public string CodigoReserva { get; set; }
        public string GrupoAlumno { get; set; }
        public string Tema { get; set; }
        public string ReservaIdGuid { get; set; }
        public Guid? CodigoTurno { get; set; }
    }
}
