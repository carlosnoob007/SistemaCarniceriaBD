using System.ComponentModel.DataAnnotations;

namespace SistemaCarniceriaBD.Models
{
    public class Compras
    {
        public int id { get; set; }

        [Required]
        public DateTime fechaCompra { get; set; }

        public int cantidadCompra { get; set; }
        public decimal totalCompra { get; set; }

        /// <summary>
        /// //////////////////////////////////////////////
        /// </summary>

        public Productos Producto { get; set; }
        public int ProductoId { get; set; }

        public Proveedores Proveedor { get; set; }
        public int ProveedorId { get; set; }
    }
}
