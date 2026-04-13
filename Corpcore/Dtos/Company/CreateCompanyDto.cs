namespace Corpcore.Dtos.Company
{
    public class CreateCompanyDto
    {
        public required string Name { get; set; }
        public required DateOnly Established { get; set; }
        public required Guid CountryId { get; set; }
        public required string Address { get; set; }
    }
}
