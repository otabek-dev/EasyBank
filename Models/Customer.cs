namespace EasyBank.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public required string FullName { get; set; }
        public required string Address { get; set; }

        public List<Card> Cards { get; set; } = new();
    }
}
