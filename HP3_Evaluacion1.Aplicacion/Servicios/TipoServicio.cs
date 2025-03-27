using Festivos.Core.Repositorios;
using Festivos.Core.Servicios;
using HP3_Evaluacion1.Core.Repositorios;
using HP3_Evaluacion1.Core.Servicios;
using HP3_Evaluacion1.Dominio.Entidades;

namespace HP3_Evaluacion1.Aplicacion.Servicios
{
    public class TipoServicio : ITipoServicio
    {
        private readonly ITipoRepositorio repositorio;

        public TipoServicio(ITipoRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public async Task<Tipo> Agregar(Tipo tipo)
        {
            return await repositorio.Agregar(tipo);
        }

        public async Task<IEnumerable<Tipo>> Buscar(string dato)
        {
            return await repositorio.Buscar(dato);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await repositorio.Eliminar(id);
        }

        public async Task<Tipo> Modificar(Tipo tipo)
        {
            return await repositorio.Modificar(tipo);
        }

        public async Task<Tipo> Obtener(int id)
        {
            return await repositorio.Obtener(id);
        }

        public async Task<IEnumerable<Tipo>> ObtenerTodos()
        {
            return await repositorio.ObtenerTodos();
        }
    }
}