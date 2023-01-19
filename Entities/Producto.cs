using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticaParcial2.Model
{
    public class Producto
    {
        [Key]
        public Guid codigoBarra { get; set; }
        public Guid idTipoProducto { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }
        [Required]
        [StringLength(150)]
        public string descripcion { get; set;}

        [ForeignKey("codigoBarra")]
        public TipoProducto tipoProducto { get; set; }  
        
    }
}
