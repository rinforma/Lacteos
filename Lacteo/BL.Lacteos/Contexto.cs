using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace BL.Lacteos
{
   public class Contexto: DbContext
    {
        public Contexto(): base("VentaLacteos")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Producto> Productos { get; set; }
    }
}
