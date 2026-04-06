using Corpcore.Models;
using Microsoft.AspNetCore.Identity;

namespace Corpcore.Services.Auth.Password
{
    public class PasswordHasherService(IPasswordHasher<string> _hasher) : IPasswordHasherService
    {
        public string Hash(string password)
            => _hasher.HashPassword(password, password);

        public bool Verify(string passwordHash, string password)
            => _hasher.VerifyHashedPassword(password, passwordHash, password)
               != PasswordVerificationResult.Failed;
    }
}
