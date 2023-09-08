using EasyBank.Models;
using System.Text.Json.Serialization;

namespace EasyBank.DTOs
{
    public class CardDto
    {
        public required string CardNumber { get; set; }
        public required string PinCode { get; set; }
        public bool IsBlocked { get; set; }
    }
}
