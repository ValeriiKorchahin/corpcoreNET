using System.ComponentModel.DataAnnotations;

namespace Corpcore.Dtos.Organization
{
    public class CreateOrganizationDto
    {
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public required string Name { get; set; }
    }
}
