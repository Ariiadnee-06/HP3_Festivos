using HP3_Evaluacion1.Dominio;
using System.Collections.Generic;
using System.Threading.Tasks;

using HP3_Evaluacion1.Dominio.Entidades;

namespace HP3_Evaluacion1.Core.Repositorios
{
    public interface Repository
    {
        Task<IEnumerable<Festivo>> ObtenerTodos();
        Task<Festivo> Obtener(int Id);
        Task<Festivo> Agregar(Festivo festivo);
        Task<Festivo> Modificar(Festivo festivo);
        Task<bool> Eliminar(int Id);
        Task<IEnumerable<Festivo>> Buscar(int Tipo, string Dato);
    }
}
