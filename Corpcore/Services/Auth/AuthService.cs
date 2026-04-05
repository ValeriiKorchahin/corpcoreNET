using Corpcore.Database;
using Corpcore.Dtos.Auth;

namespace Corpcore.Services.Auth
{
    public class AuthService(AppDbContext _context) : IAuthService
    {

        public async Task Login(LoginDto request)
        {
        
        }

        public Task Register(RegisterDto request)
        {
            return Task.CompletedTask;
        }
    }
}
