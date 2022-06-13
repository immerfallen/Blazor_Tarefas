using System.ComponentModel.DataAnnotations;

namespace Blazor_Tarefas.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage="O nome deve ser inserido.")]
        [StringLength(100, ErrorMessage="O nome não pode exceder 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail deve ser inserido.")]
        [EmailAddress(ErrorMessage = "Insira um e-mail válido.")]
        public string Email { get; set; }

        [Range(18,80, ErrorMessage ="A idade deve estar entre 18 anos e 80 anos.")]
        public int Idade { get; set; }
    }
}
