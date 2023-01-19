using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace PracticaParcial2.Model
{
    public class Carrito
    {
        [Key]
        public Guid idCarrito { get; set; }
        public Guid? codigoBarra { get; set; }
        public Guid cedulaIdentidad { get; set; }

        [ForeignKey("codigoBarra")]
        public List<Producto> listaProductos { get; set; }

        [ForeignKey("cedulaIdentidad")]
        public Persona personas { get; set; }
    }
}
