using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.JWT;
using EasyBank.Models;
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

        public (string AccessToken, string RefreshToken) CreateTokens(Employee employee)
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
                Expires = DateTime.Now.AddDays(2),
                EmployeeId = employee.Id.ToString()
            };

            // Сохраните refresh token в базу данных или другое хранилище
            _context.RefreshTokens.Add(refreshToken);
            _context.SaveChanges();

            return (encodedAccessToken, refreshToken.Token);
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

        public (string AccessToken, string NewRefreshToken) RefreshToken(RefreshTokenDto refreshTokenRequest)
        {
            var userId = GetUserIdFromExpiredToken(refreshTokenRequest.Token);

            // Валидируйте refresh token
            var storedRefreshToken = _context.RefreshTokens
                .FirstOrDefault(t => t.EmployeeId == userId && t.Token == refreshTokenRequest.RefreshToken);

            if (storedRefreshToken == null)
            {
                return (null, null);
            }

            // Удалите старый refresh token
            _context.RefreshTokens.Remove(storedRefreshToken);
            _context.SaveChanges();

            // Генерируйте новый access token и refresh token

            var emplpyee = _context.Employees.Find(Guid.Parse(userId));
            var (accessToken, newRefreshToken) =
                CreateTokens(emplpyee);

            return new()
            {
                AccessToken = accessToken,
                NewRefreshToken = newRefreshToken
            };
        }

        public string GetUserIdFromExpiredToken(string expiredToken)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.ReadJwtToken(expiredToken);
            return token.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
        }
    }
}
