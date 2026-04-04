using Corpcore.utils.Enums;
using System.ComponentModel.DataAnnotations;

namespace Corpcore.Dtos.Organization
{
    public class UpdateOrganizationRoleDto
    {
        [Required]
        public required OrganizationRolesEnum Role {  get; set; }
    }
}
