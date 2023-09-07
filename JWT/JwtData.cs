using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace EasyBank.JWT
{
    public class JwtData
    {
        private const string KEY = "top key 123 123 123 123";
        public const string ISSUER = "MyAuthServer";
        public const string AUDIENCE = "MyAuthClient";
        public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
    }
}
