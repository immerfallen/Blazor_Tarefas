using System.ComponentModel.DataAnnotations;

namespace Blazor_Tarefas.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Range(18,80, ErrorMessage ="A idade deve estar entre 18 anos e 80 anos")]
        public int Idade { get; set; }
    }
}
