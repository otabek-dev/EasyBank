namespace EasyBank.Models
{
    public class Report
    {
        public string? OperationInfo { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
