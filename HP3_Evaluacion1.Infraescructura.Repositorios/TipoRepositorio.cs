using Festivos.Core.Repositorios;
using FestivosApp.Persistencia.Contexto;
using HP3_Evaluacion1.Core.Repositorios;
using HP3_Evaluacion1.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FestivosApp.Persistencia.Contexto
{
    public class TipoRepositorio : ITipoRepositorio
    {
        private readonly FestivosContext context;

        public TipoRepositorio(FestivosContext context)
        {
            this.context = context;
        }

        public async Task<Tipo> Agregar(Tipo tipo)
        {
            context.Tipos.Add(tipo);
            await context.SaveChangesAsync();
            return tipo;
        }

        public async Task<IEnumerable<Tipo>> Buscar(string dato)
        {
            return await context.Tipos
                .Where(item => item.Nombre.Contains(dato))
                .ToListAsync();
        }

        public async Task<bool> Eliminar(int id)
        {
            var tipo = await context.Tipos.FindAsync(id);
            if (tipo == null) return false;
                
            try
            {
                context.Tipos.Remove(tipo);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }   
        }

        public async Task<Tipo> Modificar(Tipo tipo)
        {
            context.Tipos.Update(tipo);
            await context.SaveChangesAsync();
            return tipo;
        }

        public async Task<Tipo> Obtener(int id)
        {
            return await context.Tipos.FindAsync(id);
        }

        public async Task<IEnumerable<Tipo>> ObtenerTodos()
        {
            return await context.Tipos.ToListAsync();
        }
    }

    public class FestivoRepositorio : IFestivoRepositorio
    {
        private readonly HP3_Evaluacion1 context;

        public FestivoRepositorio(HP3_Evaluacion1 context)
        {
            this.context = context;
        }

        public async Task<Festivo> Agregar(Festivo festivo)
        {
            context.Festivos.Add(festivo);
            await context.SaveChangesAsync();
            return festivo;
        }

        public async Task<IEnumerable<Festivo>> Buscar(int idTipo, string dato)
        {
            return await context.Festivos
                .Where(item => (idTipo == 0 || item.IdTipo == idTipo) && item.Nombre.Contains(dato))
                .ToListAsync();
        }

        public async Task<bool> Eliminar(int id)
        {
            var festivo = await context.Festivos.FindAsync(id);
            if (festivo == null) return false;

            context.Festivos.Remove(festivo);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<Festivo> Modificar(Festivo festivo)
        {
            context.Festivos.Update(festivo);
            await context.SaveChangesAsync();
            return festivo;
        }

        public async Task<Festivo> Obtener(int id)
        {
            return await context.Festivos.FindAsync(id);
        }

        public async Task<IEnumerable<Festivo>> ObtenerTodos()
        {
            return await context.Festivos.ToListAsync();
        }
    }
}
