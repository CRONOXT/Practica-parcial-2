using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticaParcial2.Model
{
    public class TipoProducto
    {
        [Key]
        public Guid idTipoProducto { get; set; }

        [Required]
        [StringLength(50)]
        public string tipo { get; set; }

        public List<Producto> productos { get; set; }
    }
}
