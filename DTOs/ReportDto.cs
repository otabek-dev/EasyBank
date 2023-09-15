using EasyBank.Models;
using System.ComponentModel.DataAnnotations;

namespace EasyBank.DTOs
{
    public class ReportDto
    {
        public required Guid EmployeeId { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
       
    }
}
