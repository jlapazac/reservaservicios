using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservaServicios.Api.Reserva.Aplicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaServicios.Api.Reserva.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaDocenteController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ReservaDocenteController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecuta Data)
        {
            return await _mediator.Send(Data);
        }
        [HttpGet]
        public async Task<ActionResult<List<ReservaDocenteDto>>> GetReservas()
        {
            return await _mediator.Send(new Consulta.Ejecuta());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ReservaDocenteDto>> GetReservaUnica(Guid id)
        {
            return await _mediator.Send(new ConsultaFiltro.ReservaUnica { ReservaDocenteId = id });
        }
    }
}
