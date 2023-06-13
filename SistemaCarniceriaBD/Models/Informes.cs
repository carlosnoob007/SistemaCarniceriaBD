using System.ComponentModel.DataAnnotations;

namespace SistemaCarniceriaBD.Models
{
    public class Informes
    {
        public int id { get; set; }

        [Required]
        public string tipoInforme { get; set; }

        [Required]
        public DateTime fechaInforme { get; set; }

        public string descripciónInforme { get; set; }
    }
}
