using System.ComponentModel.DataAnnotations;

namespace LojaVirtual.Models
{
    public class Contato
    {
        [Required]
        [MinLength(3)]
        public string Nome { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [MinLength(10)]
        public string Texto { get; set; }
    }
}