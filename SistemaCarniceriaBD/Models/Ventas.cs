using System.ComponentModel.DataAnnotations;

namespace SistemaCarniceriaBD.Models
{
    public class Ventas
    {
        public int id { get; set; }

        [Required]
        public DateTime fechaVenta { get; set; }

        
        public int cantidadVenta { get; set; }
        public decimal totalVenta { get; set; }

        /// <summary>
        /// ///////////////////////////////////////////////
        /// </summary>

        public Productos Producto { get; set; }
        public int ProductoId { get; set; }

        public Usuarios Vendedor { get; set; }
        public int VendedorId { get; set; }
    }
}
