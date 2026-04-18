namespace Corpcore.Dtos.Utils
{
    public class CountryDto
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Code { get; set; }
    }
}
