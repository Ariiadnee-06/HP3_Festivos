using HP3_Evaluacion1.Core.Servicios;
using HP3_Evaluacion1.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace HP3_Evaluacion1.Presentacion.Controladores
{
    [ApiController]
    [Route("api/Festivo")]
    public class FestivoControlador : ControllerBase
    {
        private readonly IFestivoServicio servicio;

        public FestivoControlador(IFestivoServicio servicio)
        {
            this.servicio = servicio;
        }

        [HttpGet("listar")]
        public async Task<IEnumerable<Festivo>> ObtenerTodos()
        {
            return await servicio.ObtenerTodos();
        }

        [HttpGet("obtener/{Id}")]
        public async Task<Festivo> Obtener(int Id)
        {
            return await servicio.Obtener(Id);
        }

        [HttpGet("buscar/{Festivo}/{Dato}")]
        public async Task<IEnumerable<Festivo>> Buscar(int Festivo, string Dato)
        {
            return await servicio.Buscar(Festivo, Dato);
        }

        [HttpPost("agregar")]
        public async Task<Festivo> Agregar([FromBody] Festivo festivo)
        {
            return await servicio.Agregar(festivo);
        }

        [HttpPut("modificar")]
        public async Task<Festivo> Modificar([FromBody] Festivo festivo)
        {
            return await servicio.Modificar(festivo);
        }

        [HttpDelete("eliminar/{Id}")]
        public async Task<bool> Eliminar(int Id)
        {
            return await servicio.Eliminar(Id);
        }

    }
}
