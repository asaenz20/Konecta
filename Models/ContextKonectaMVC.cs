using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Konecta
{
    public partial class ContextKonectaMVC : DbContext
    {
        public ContextKonectaMVC() : base("name=ContextKonectaMVC")
        {
        }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Solicitud> Solicitud { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>()
                .Property(e => e.ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.SALARIO)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Solicitud)
                .WithOptional(e => e.Empleado)
                .HasForeignKey(e => e.ID_EMPLEADO);

            modelBuilder.Entity<Solicitud>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<Solicitud>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<Solicitud>()
                .Property(e => e.RESUMEN)
                .IsUnicode(false);

            modelBuilder.Entity<Solicitud>()
                .Property(e => e.ID_EMPLEADO)
                .HasPrecision(18, 0);
        }
    }
}
