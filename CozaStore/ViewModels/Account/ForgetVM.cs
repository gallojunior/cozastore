using System.ComponentModel.DataAnnotations;

namespace CozaStore.ViewModels.Account;

public class ForgetVM
{
    [Display(Name = "Informe seu Email de Cadastro")]
    [Required(ErrorMessage = "Por favor, informe seu Email")]
    [EmailAddress(ErrorMessage = "Por favor, informe um Email Válido!")]
    [StringLength(100, ErrorMessage = "O Email deve possuir no máximo 100 caracteres")]
    public string Email { get; set; }

    public bool Enviado { get; set; } = false;
}

