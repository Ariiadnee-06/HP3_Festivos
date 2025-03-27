using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestivosApp.Persistencia.Contexto;
using HP3_Evaluacion1.Core.Repositorios;
using HP3_Evaluacion1.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace HP3_Evaluacion1.Infraescructura.Repositorios
{

    public class FestivoRepositorio : IFestivoRepositorio
    {
        private readonly FestivosContext context;

        public FestivoRepositorio(FestivosContext context)
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
