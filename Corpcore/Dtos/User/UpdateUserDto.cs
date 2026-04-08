using System.ComponentModel.DataAnnotations;

namespace Corpcore.Dtos.Organization
{
    public class UpdateUserDto
    {
        [Required]
        [MinLength(2)]
        public required string Name { get; set; }

        [EmailAddress]
        public required string Email { get; set; }
    }
}
