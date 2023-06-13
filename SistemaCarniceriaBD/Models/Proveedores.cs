using System.ComponentModel.DataAnnotations;

namespace SistemaCarniceriaBD.Models
{
    public class Proveedores
    {
        public int id { get; set; }

        [Required]
        public string nombreProveedor { get; set; }

        [Required]
        public string dirección { get; set; }

        [Required]
        public string teléfono { get; set; }

        [Required]
        [EmailAddress]
        public string correoElectrónico { get; set; }
    }
}
