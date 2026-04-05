using Azure.Identity;
using Corpcore.utils.Enums;
using System.ComponentModel.DataAnnotations;

namespace Corpcore.Dtos.Auth
{
    public class RegisterDto
    {
        [Required]
        [MinLength(2)]
        public required string UserName { get; set; }
        [Required]
        [MinLength(8)]
        public required string Password { get; set; }
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        public OrganizationRolesEnum Role { get; } = OrganizationRolesEnum.MANAGER;
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public required string OrganizationName { get; set; }

    }
}
