using Corpcore.Models;

namespace Corpcore.Services.JWT
{
    public interface IJwtTokenService
    {
        string GenerateToken(User user);
    }
}
