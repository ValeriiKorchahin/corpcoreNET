using System.ComponentModel.DataAnnotations;

namespace Corpcore.Dtos.Auth
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        [Required]
        [MinLength(8)]
        public required string Password { get; set; }    
    }
}
