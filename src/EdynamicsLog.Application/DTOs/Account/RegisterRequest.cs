using EdynamicsLog.Application.Enums;
using System.ComponentModel.DataAnnotations;

namespace EdynamicsLog.Application.DTOs.Account
{
    public class RegisterRequest
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Dni { get; set; }

        public string Photo { get; set; }

        public Domain.Common.Enums.Status Status { get; set; }

        public Domain.Common.Enums.Gender Sexo { get; set; }
        public Domain.Common.Enums.RolPaket Rol { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
