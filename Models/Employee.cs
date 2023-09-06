namespace EasyBank.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!; 
        public string Position { get; set; } = null!;
        public string Role { get; set; } = null!;
    }
}