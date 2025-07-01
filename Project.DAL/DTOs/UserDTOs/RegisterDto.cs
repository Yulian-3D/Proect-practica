using Project.DAL.Validators;
using System.ComponentModel.DataAnnotations;

namespace Project.DAL.DTOs.UserDTOs
{
    public class RegisterDto
    {
        [Required]
        [MaxLength(60)]
        public string Name { get; set; } = null!;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        [MinLength(8)]
        [Required]
        [PasswordValidator(ErrorMessage = "Password must contain at least 1 digit,1 Upper Case and 1 Lower Case Letter")]
        public string Password { get; set; } = null!;
    }
}
