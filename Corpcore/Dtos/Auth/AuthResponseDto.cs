using Corpcore.utils.Enums;

namespace Corpcore.Dtos.Auth
{
    public class AuthResponseDto
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public OrganizationRolesEnum Role { get; set; }
        public Guid OrganizationId { get; set; }
        public required string Token { get; set; }
    }
}
