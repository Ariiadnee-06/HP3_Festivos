using HP3_Evaluacion1.Dominio.Entidades;

namespace Festivos.Core.Repositorios
{
    public interface ITipoRepositorio
    {
        Task<IEnumerable<Tipo>> ObtenerTodos();

        Task<Tipo> Obtener(int id);

        Task<Tipo> Agregar(Tipo tipo);

        Task<Tipo> Modificar(Tipo tipo);

        Task<bool> Eliminar(int id);
    }
}