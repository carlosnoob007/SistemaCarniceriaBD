using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaCarniceriaBD.Models
{
    public class Productos
    {
        public int id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string nombreProducto { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string categoriaProducto { get; set; }

        public decimal precioProducto { get; set; }
        public DateTime fechaEntrada { get; set; }
        public DateTime fechaVencimiento { get; set; }
    }
}
