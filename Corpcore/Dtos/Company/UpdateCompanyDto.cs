using Corpcore.Validators.Date;
using System.ComponentModel.DataAnnotations;

namespace Corpcore.Dtos.Company
{
    public class UpdateCompanyDto
    {
        [Required]
        public required string Name { get; set; }
        [Required]
        [NoFutureDate]
        public required DateOnly Established { get; set; }
        [Required]
        public required Guid CountryId { get; set; }
        [Required]
        public required string Address { get; set; }
    }
}
