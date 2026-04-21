using Corpcore.Utils.Enums;

namespace Corpcore.Models
{
    public class UserCompany
    {
        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public CompanyRolesEnum Role {  get; set; }
    }
}
