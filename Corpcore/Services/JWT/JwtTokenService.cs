using Corpcore.Dtos.JWT;
using Corpcore.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Corpcore.Services.JWT
{
    public class JwtTokenService(IOptions<JwtToken> _jwtToken): IJwtTokenService
    {
        public string GenerateToken(User user) 
        {
            var claims = new[]
            {
                new Claim("userId", user.Id.ToString()),
                new Claim("organizationId", user.OrganizationId.ToString()),
                new Claim("role", user.Role.ToString())
            };

            var securityKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_jwtToken.Value.SecretKey)
                );
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _jwtToken.Value.Issuer,
                audience: _jwtToken.Value.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddDays(_jwtToken.Value.ExpiresInDays),
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
