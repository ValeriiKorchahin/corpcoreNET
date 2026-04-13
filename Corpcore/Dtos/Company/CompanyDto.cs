namespace Corpcore.Dtos.Company
{
    public class CompanyDto
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required DateOnly Established { get; set; }
        public required Guid CountryId { get; set; }
        public required string Address { get; set; }
        public required Guid OrganizationId { get; set; }
    }
}
