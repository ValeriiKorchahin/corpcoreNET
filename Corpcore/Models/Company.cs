namespace Corpcore.Models
{
    public class Company
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required DateOnly Established { get; set; }
        public required Guid CountryId { get; set; }
        public required string Address { get; set; }
        public required Guid OrganizationId { get; set; }
        public Organization? Organization { get; set; }
        public Country? Country { get; set; }
        public ICollection<UserCompany> CompanyUsers { get; set; } = new List<UserCompany>();
    }
}
