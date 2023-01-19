using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticaParcial2.Model
{
    public class Persona
    {
        [Key]
        public Guid cedulaIdentidad { get; set; }
       
        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string apellido { get; set; }

        public Carrito carrito { get; set; }
    }
}
