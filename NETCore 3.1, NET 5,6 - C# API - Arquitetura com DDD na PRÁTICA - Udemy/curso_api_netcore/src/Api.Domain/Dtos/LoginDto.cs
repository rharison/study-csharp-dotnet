using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos {
    public class LoginDto {
        [Required(ErrorMessage = "Email é um campo obrigatório para login.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        [StringLength(100, ErrorMessage = "Email deve ter no máximo {1} caracteres.")]
        public string Email { get; set; }
    }
}
