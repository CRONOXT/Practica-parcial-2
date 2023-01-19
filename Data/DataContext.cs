using Microsoft.EntityFrameworkCore;
using PracticaParcial2.Model;

namespace PracticaParcial2.Data
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Producto> productos { get; set; }
        public DbSet<TipoProducto> tipos { get; set; }  
        public DbSet<Persona> personas { get; set; }
        public DbSet<Carrito> carritos { get; set; }

        public DbContext DbContext
        {
            get
            {
                return this;
            }
        }
    }
}
