using System.Text.Json.Serialization;

namespace EasyBank.Models
{
    public class History
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
        public required OperationType OperationType { get; set; }
        public required OperationDescription OperationDescription { get; set; }
        
        [JsonIgnore]
        public Employee? Employee { get; set; }
        public Guid? EmployeeId { get; set; }
    }

}
