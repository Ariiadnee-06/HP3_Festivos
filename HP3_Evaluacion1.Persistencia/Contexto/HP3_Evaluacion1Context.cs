using HP3_Evaluacion1.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FestivosApp.Persistencia.Contexto
{
    public class FestivosContext : DbContext
    {
        public FestivosContext(DbContextOptions<FestivosContext> options)
            : base(options)
        {
        }

        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Festivo> Festivos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configuración de la entidad Tipo
            builder.Entity<Tipo>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.Property(e => e.Nombre).HasMaxLength(100).IsRequired();
            });

            // Configuración de la entidad Festivo
            builder.Entity<Festivo>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.Property(e => e.Nombre).HasMaxLength(100).IsRequired();
                entidad.Property(e => e.Dia).IsRequired();
                entidad.Property(e => e.Mes).IsRequired();
                entidad.Property(e => e.DiasPascua).IsRequired();

                // Relación con Tipo
                entidad.HasOne(e => e.Tipo)
                    .WithMany()
                    .HasForeignKey(e => e.IdTipo);
            });
        }
    }
}
