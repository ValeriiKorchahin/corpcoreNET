using Corpcore.Models;
using Microsoft.AspNetCore.Identity;

namespace Corpcore.Services.Auth.Password
{
    public class PasswordHasherService(IPasswordHasher<User> _hasher) : IPasswordHasherService
    {
        public string Hash(User user)
            => _hasher.HashPassword(user, user.Password);

        public bool Verify(User user, string password)
            => _hasher.VerifyHashedPassword(user, user.Password, password)
               != PasswordVerificationResult.Failed;
    }
}
