using Corpcore.Models;

namespace Corpcore.Services.Auth.Password
{
    public interface IPasswordHasherService
    {
        string Hash(User user);
        bool Verify(User user, string password);    
    }
}
