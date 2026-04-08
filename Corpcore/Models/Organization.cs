namespace Corpcore.Models
{
    public class Organization
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
