using Corpcore.Models;

namespace Corpcore.Services.Auth.Password
{
    public interface IPasswordHasherService
    {
        string Hash(string password);
        bool Verify(string passwordHash, string password);    
    }
}
