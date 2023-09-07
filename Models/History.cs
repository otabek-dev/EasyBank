namespace EasyBank.Models
{
    public class History
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
        public required string OperationType { get; set; }
        public required string OperatorId { get; set; }

        public Guid? CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public Guid? CardId { get; set; }
        public Card? Card { get; set; }
    }

}
