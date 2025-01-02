
using Microsoft.EntityFrameworkCore;
using TestEfective.Modelos;

namespace TestEfective.Context
{
    public class testDBContext : DbContext
    {
        public testDBContext(DbContextOptions<testDBContext> options) : base(options)
        {}

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public DbSet<EstadoCivil> estadoCivil { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
