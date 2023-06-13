using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaCarniceriaBD.Models
{
    public class Login
    {
        public int id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string usuario { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string contraseña { get; set; }


        /// <summary>
        /// //////////////////////////////////////////
        /// </summary>
        public Usuarios Usuarios { get; set; }
        public int UsuariosId { get; set; }
    }
}
