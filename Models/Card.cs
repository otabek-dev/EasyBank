using System.Text.Json.Serialization;

namespace EasyBank.Models
{
    public class Card
    {
        public Guid Id { get; set; }
        public required string CardNumber { get; set; }
        public required string PinCode { get; set; }
        public bool IsBlocked { get; set; }

        [JsonIgnore]
        public Customer? Customer { get; set; }
        public Guid CustomerId { get; set; }
    }
}
