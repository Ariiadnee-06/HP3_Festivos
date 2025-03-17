using HP3_Evaluacion1.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP3_Evaluacion1.Core.Repositorios
{
    public interface IFestivoRepositorio
    {
        Task<IEnumerable<Festivo>> ObtenerTodos();

        Task<Festivo> Obtener(int id);

        Task<Festivo> Agregar(Festivo festivo);

        Task<Festivo> Modificar(Festivo festivo);

        Task<bool> Eliminar(int id);

        Task<IEnumerable<Festivo>> Buscar(int idTipo, string dato);
    }
}