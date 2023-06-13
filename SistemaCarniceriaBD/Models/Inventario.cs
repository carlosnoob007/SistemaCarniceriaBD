using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaCarniceriaBD.Models
{
    public class Inventario
    {
        public int id { get; set; }

        public int cantidad { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string descripción { get; set; }


        /// <summary>
        /// ///////////////////////////////////////////////
        /// </summary>

        public Productos Producto { get; set; }
        public int ProductoId { get; set; }

        
        public Proveedores Proveedor { get; set; }
        public int ProveedorId { get; set; }
    }
}
