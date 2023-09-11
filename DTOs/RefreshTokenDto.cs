namespace EasyBank.DTOs
{
    public class RefreshTokenDto
    {
        public required string Token { get; set; }
        public required string RefreshToken { get; set; }
    }
}
