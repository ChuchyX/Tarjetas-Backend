using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Tarjetas
{
    public class Tarjeta
    {      
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Titular { get; set; }

        [Required]
        public string NumeroTarjeta { get; set; }

        [Required]
        public string FechaExpiracion { get; set; }

        [Required]
        public string CVV { get; set; }       
    }
}
