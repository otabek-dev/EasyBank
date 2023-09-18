namespace EasyBank.Models
{
    internal class Report
    {
        public string OperationType { get; set; } = string.Empty;
        public string OperationDescription { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public int Count { get; set; }
    }
}