namespace EasyBank.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public required string FullName { get; set; }
        public required string Position { get; set; }
        public required string Role { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public string? Phone { get; set; }

        public List<History>? History { get; set; } = new();
    }
}