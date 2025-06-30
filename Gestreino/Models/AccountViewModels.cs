using System.ComponentModel.DataAnnotations;
namespace Gestreino.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "{0} é um campo obrigatório!")]
        [Display(Name = "Utilizador")]
        [DataType(DataType.Text)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} é um campo obrigatório!")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Display(Name = "Lembrar de Min?")]
        public bool RememberMe { get; set; }
    }
    public class PasswordResetViewModel
    {
        [EmailAddress(ErrorMessage = "{0} não é válido!")]
        [Display(Name = "Email")]
        [DataType(DataType.Text)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "{0} não é válido!")]
        [StringLength(100, ErrorMessage = "{0} deve ter o mínimo de {2} dígitos", MinimumLength = 9)]
        [Display(Name = "Número de telemóvel")]
        public string Telephone { get; set; }

        [Display(Name = "Número de estudante")]
        [DataType(DataType.Text)]
        public string Login { get; set; }

        [Display(Name = "Número de identificação (Nº de B.I. ou Passaporte apresentado no acto da inscrição)")]
        [DataType(DataType.Text)]
        public string BI { get; set; }

        [StringLength(100, ErrorMessage = "A {0} de acesso deve ter o mínimo de {2} caracteres", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Nova senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmação da senha")]
        [Compare("Password", ErrorMessage = "A senha de acesso não é idêntica a confirmação.")]
        public string ConfirmPassword { get; set; }
    }

    public class PasswordResetTokenViewModel
    {
        [Required(ErrorMessage = "{0} é um campo obrigatório!")]
        [StringLength(100, ErrorMessage = "A {0} de acesso deve ter o mínimo de {2} caracteres", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Nova senha")]
        public string Password { get; set; }

        [Required(ErrorMessage = "{0} é um campo obrigatório!")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmação")]
        [Compare("Password", ErrorMessage = "A senha de acesso não é idêntica a confirmação.")]
        public string ConfirmPassword { get; set; }
        public int TOKENID { get; set; }
        public string TOKEN { get; set; }

        public int Status { get; set; }

        public string Email { get; set; }

        [Display(Name = "Utilizador")]
        [DataType(DataType.Text)]
        public string Login { get; set; }
    }


    public class ProfileViewModel
    {
        [Required(ErrorMessage = "{0} é um campo obrigatório!")]
        [StringLength(100, ErrorMessage = "A {0} de acesso deve ter o mínimo de {2} caracteres", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "{0} é um campo obrigatório!")]
        [StringLength(100, ErrorMessage = "A {0} deve ter o mínimo de {2} caracteres", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Nova senha")]
        public string Password { get; set; }

        [Required(ErrorMessage = "{0} é um campo obrigatório!")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmação")]
        [Compare("Password", ErrorMessage = "A senha de acesso não é idêntica a confirmação.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Gerar senha")]
        public bool isAutomaticPasswordEmail { get; set; }
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string TelefoneAlternativo { get; set; }
        public string Endereco { get; set; }
        public string BIPassaporte { get; set; }
        public string DataCriacao { get; set; }

        [Display(Name = "Utilizador")]
        [DataType(DataType.Text)]
        public string Login { get; set; }
    }
}