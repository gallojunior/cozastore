using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CozaStore.ViewModels.Account;

public class ResetPasswordVM
{
    [Display(Prompt = "Informe seu Email")]
    [Required(ErrorMessage = "Por favor, informe seu Email")]
    [EmailAddress(ErrorMessage = "Por favor, informe um Email Válido!")]
    [StringLength(100, ErrorMessage = "O Email deve possuir no máximo 100 caracteres")]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Senha de Acesso", Prompt = "Informe uma Senha para Acesso")]
    [Required(ErrorMessage = "Por favor, informe sua Senha de Acesso")]
    [StringLength(20, MinimumLength = 6, ErrorMessage = "A Senha deve possuir no minimo 6 e no máximo 20 caracteres")]
    public string Senha { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirmar Senha de Acesso", Prompt = "Confirme sua Senha de Acesso")]
    [Compare("Senha", ErrorMessage = "As Senhas não Conferem.")]
    public string ConfirmacaoSenha { get; set; }

    [HiddenInput]
    [Required]
    public string Code { get; set; }

    public bool Enviado { get; set; } = false;
}
