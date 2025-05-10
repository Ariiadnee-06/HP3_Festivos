using HP3_Evaluacion1.Dominio.Entidades;

namespace Festivos.Core.Servicios
{
    public interface ITipoServicio
    {
        Task<IEnumerable<Tipo>> ObtenerTodos();

        Task<Tipo> Obtener(int id);

        Task<Tipo> Agregar(Tipo tipo);

        Task<Tipo> Modificar(Tipo tipo);

        Task<bool> Eliminar(int id);

<<<<<<< HEAD
        Task<IEnumerable<Tipo>> Buscar(string dato);
=======
        Task<IEnumerable<Tipo>> Buscar(int Tipo,string dato);
>>>>>>> 6331e77 (Agregar archivos de proyecto.)
    }
}