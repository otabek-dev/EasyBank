namespace EasyBank.Models
{
    public class RefreshToken
    {
        public Guid Id { get; set; }
        public required string Token { get; set; }
        public DateTime Expires { get; set; }
        public required string EmployeeId { get; set; }
    }
}
