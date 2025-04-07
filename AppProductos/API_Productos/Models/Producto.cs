using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Productos.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "El campo{0} debe tener maximo {1} caracteres.")]
        public String? Nombre { get; set; }
        // se utiliza Range para que no se utilizen numeros negativos y [Column(TypeName para crear columna Decimal(10,2) 
        [Column(TypeName = "decimal(10,2)")]
        [Range(0, 99999999.99, ErrorMessage = "El precio debe estar entre 0 y 99,999,999.99")]
        public decimal Precio { get; set; }

        public int Stock { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime FechaCreacion { get; set; }


    }
}
