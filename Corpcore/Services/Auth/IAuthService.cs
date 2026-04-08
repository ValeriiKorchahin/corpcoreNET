using Corpcore.Dtos.Auth;

namespace Corpcore.Services.Auth
{
    public interface IAuthService
    {
        Task<AuthResponseDto> Login(LoginDto request);
        Task<AuthResponseDto> Register(RegisterDto request);
    }
}
