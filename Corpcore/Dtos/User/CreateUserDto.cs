using Corpcore.utils.Enums;
using System.ComponentModel.DataAnnotations;

namespace Corpcore.Dtos.User
{
    public class CreateUserDto
    {
        [Required]
        [MinLength(2)]
        public required string Name { get; set; }
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        [Required]
        [MinLength(8)]
        public required string Password { get; set; }
        public OrganizationRolesEnum Role { get; set; } = OrganizationRolesEnum.USER;

        [Required]
        public Guid OrganizationId { get; set; }
    }
}
