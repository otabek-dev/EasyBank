using EasyBank.Models;

namespace EasyBank.DTOs
{
    public class ReportDto
    {
        public Guid EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
       
    }
}
