using Corpcore.Dtos.Auth;

namespace Corpcore.Services.Auth
{
    public interface IAuthService
    {
        Task Login(LoginDto request);
        Task Register(RegisterDto request);
    }
}
