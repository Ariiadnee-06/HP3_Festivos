using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HP3_Evaluacion1.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace HP3_Evaluacion1.Infraescructura.Persistencia.Contexto
{
    public class HP3_Evaluacion1Context : DbContext
    {
        public HP3_Evaluacion1Context(DbContextOptions<HP3_Evaluacion1Context> options) : base(options)
        {
        }

        public DbSet<Festivo> Festivos { get; set; }
        public DbSet<Tipo> Tipos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tipo>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            modelBuilder.Entity<Festivo>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();

                entidad.HasOne(e => e.Tipo)
                    .WithMany()
                    .HasForeignKey(e => e.IdTipo);
            });
        }

    }
}

