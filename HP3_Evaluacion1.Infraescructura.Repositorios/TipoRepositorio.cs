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
}
