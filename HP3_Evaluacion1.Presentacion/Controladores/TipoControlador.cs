using Festivos.Core.Servicios;
using HP3_Evaluacion1.Core.Servicios;
using HP3_Evaluacion1.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace HP3_Evaluacion1.Presentacion.Controllers
{
    [ApiController]
    [Route("api/Tipo")]
    public class TipoContralador : ControllerBase
    {
        private readonly ITipoServicio servicio;

        public TipoContralador(ITipoServicio servicio)
        {
            this.servicio = servicio;
        }

        [HttpGet("listar")]
        public async Task<IEnumerable<Tipo>> ObtenerTodos()
        {
            return await servicio.ObtenerTodos();
        }

        [HttpGet("obtener/{Id}")]
        public async Task<Tipo> Obtener(int Id)
        {
            return await servicio.Obtener(Id);
        }

        [HttpGet("buscar/{Tipo}/{Dato}")]
        public async Task<IEnumerable<Tipo>> Buscar(int Tipo, string Dato)
        {
            return await servicio.Buscar(Tipo, Dato);
        }

        [HttpPost("agregar")]
        public async Task<Tipo> Agregar([FromBody] Tipo Tipo)
        {
            return await servicio.Agregar(Tipo);
        }

        [HttpPut("modificar")]
        public async Task<Tipo> Modificar([FromBody] Tipo tipo)
        {
            return await servicio.Modificar(tipo);
        }

        [HttpDelete("eliminar/{Id}")]
        public async Task<bool> Eliminar(int Id)
        {
            return await servicio.Eliminar(Id);
        }

    }
}
