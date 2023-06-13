using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaCarniceriaBD.Models
{
    public class Usuarios
    {
        public int id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string nombreUsuario { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string apellidoUsuario { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string cedulaUsuario { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string rol { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string usuario { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string clave { get; set; }
    }
}
