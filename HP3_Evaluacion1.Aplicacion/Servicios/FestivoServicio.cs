using HP3_Evaluacion1.Core.Repositorios;
using HP3_Evaluacion1.Core.Servicios;
using HP3_Evaluacion1.Dominio.Entidades;

namespace HP3_Evaluacion1.Aplicacion.Servicios
{
    public class FestivoServicio : IFestivoServicio
    {
        private readonly IFestivoRepositorio repositorio;

        public FestivoServicio(IFestivoRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public async Task<Festivo> Agregar(Festivo festivo)
        {
            return await repositorio.Agregar(festivo);
        }

        public async Task<IEnumerable<Festivo>> Buscar(int tipo, string dato)
        {
            return await repositorio.Buscar(tipo, dato);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await repositorio.Eliminar(id);
        }

        public async Task<Festivo> Modificar(Festivo festivo)
        {
            return await repositorio.Modificar(festivo);
        }

        public async Task<Festivo> Obtener(int id)
        {
            return await repositorio.Obtener(id);
        }

        public async Task<IEnumerable<Festivo>> ObtenerTodos()
        {
            return await repositorio.ObtenerTodos();
        }
    }
}