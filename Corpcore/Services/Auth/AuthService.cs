using Corpcore.Database;
using Corpcore.Dtos.Auth;
using Corpcore.Models;
using Corpcore.Services.Auth.Password;
using Microsoft.EntityFrameworkCore;

namespace Corpcore.Services.Auth
{
    public class AuthService(
        AppDbContext _context,
        IPasswordHasherService _passwordHasher
        ) : IAuthService
    {

        public async Task<AuthResponseDto> Login(LoginDto request)
        {
            var user = await _context.Users
               .FirstOrDefaultAsync(u => u.Email == request.Email);

            if (user == null)
                throw new Exception("Invalid credentials");

            bool isPasswordCorrect = _passwordHasher.Verify(user, request.Password);

            if (!isPasswordCorrect)
                throw new Exception("Invalid credentials");

            var response = new AuthResponseDto
            {
                Id = user.Id,
                Email = user.Email,
                Name = user.Name,
                Role = user.Role,
                OrganizationId = user.OrganizationId
            };

            return response;
        }

        public async Task<AuthResponseDto> Register(RegisterDto request)
        {
            var isExistingUser = await _context.Users
               .AnyAsync(u => u.Email == request.Email);

            if (isExistingUser)
            {
                throw new Exception("User already exists.");
            }

            var isExistingOrganization = await _context.Organizations
                .AnyAsync(o => o.Name == request.OrganizationName);

            if (isExistingOrganization) 
            {
                throw new Exception("Organization already exists.");
            }

            var organization = new Organization
            {
                Id = Guid.NewGuid(),
                Name = request.OrganizationName,
            };

            var user = new User
            {
                Id = Guid.NewGuid(),
                Email = request.Email,
                Password = request.Password,
                Name = request.UserName,
                Role = utils.Enums.OrganizationRolesEnum.MANAGER,
                OrganizationId = organization.Id,
            };

            user.Password = _passwordHasher.Hash(user);

            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                _context.Organizations.Add(organization);
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }

            var response = new AuthResponseDto
            {
                Id = user.Id,
                Email = user.Email,
                Name = user.Name,
                Role = user.Role,
                OrganizationId = organization.Id,
            };

            return response;
        }
    }
}
