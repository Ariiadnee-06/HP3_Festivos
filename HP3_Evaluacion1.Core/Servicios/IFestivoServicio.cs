using HP3_Evaluacion1.Dominio.Entidades;
namespace HP3_Evaluacion1.Core.Servicios
{
    public interface IFestivoServicio
    {
        Task<IEnumerable<Festivo>> ObtenerTodos();

        Task<Festivo> Obtener(int id);

        Task<Festivo> Agregar(Festivo festivo);

        Task<Festivo> Modificar(Festivo festivo);

        Task<bool> Eliminar(int id);

        Task<IEnumerable<Festivo>> Buscar(int idTipo, string dato);
    }
}
