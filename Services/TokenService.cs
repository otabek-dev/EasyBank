using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.JWT;
using EasyBank.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace EasyBank.Services
{
    public class TokenService
    {
        public readonly AppDbContext _context;

        public TokenService(AppDbContext context)
        {
            _context = context;
        }

        private string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        private async Task RemoveExpiredRefreshTokensAsync()
        {
            var currentTime = DateTime.UtcNow;

            var expiredTokens = await _context.RefreshTokens
                .Where(rt => rt.Expires < currentTime)
                .ToListAsync();

            _context.RefreshTokens.RemoveRange(expiredTokens);
            await _context.SaveChangesAsync();
        }

        public async Task<TokensDto> CreateTokensAsync(Employee employee)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Role, employee.Role),
                new Claim(ClaimTypes.NameIdentifier, employee.Id.ToString())
            };

            var accessToken = new JwtSecurityToken(
                issuer: JwtData.ISSUER,
                audience: JwtData.AUDIENCE,
                claims: claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: new SigningCredentials(
                    JwtData.GetSymmetricSecurityKey(),
                    SecurityAlgorithms.HmacSha256));

            var encodedAccessToken = new JwtSecurityTokenHandler().WriteToken(accessToken);

            var refreshToken = new RefreshToken
            {
                Token = GenerateRefreshToken(),
                Expires = DateTime.UtcNow.AddDays(2),
                EmployeeId = employee.Id.ToString()
            };

            await _context.RefreshTokens.AddAsync(refreshToken);
            await _context.SaveChangesAsync();

            return new TokensDto { Token = encodedAccessToken, RefreshToken = refreshToken.Token };
        }

        public async Task<TokensDto> RefreshTokenAsync(RefreshTokenDto refreshTokenRequest)
        {
            var userId = GetUserIdFromToken(refreshTokenRequest.Token);
            if (userId is null) return new();

            var storedRefreshToken = _context.RefreshTokens
                .FirstOrDefault(t => t.EmployeeId == userId 
                && t.Token == refreshTokenRequest.RefreshToken);
            if (storedRefreshToken == null) return new();

            _context.RefreshTokens.Remove(storedRefreshToken);
            await _context.SaveChangesAsync();

            var emplpyee = await _context.Employees.FindAsync(Guid.Parse(userId));
            if(emplpyee is null) return new();
            
            var tokens = await CreateTokensAsync(emplpyee);
            return new TokensDto { Token = tokens.Token, RefreshToken = tokens.RefreshToken};
        }

        private string? GetUserIdFromToken(string userToken)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.ReadJwtToken(userToken);
            return token.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
        }
    }
}
