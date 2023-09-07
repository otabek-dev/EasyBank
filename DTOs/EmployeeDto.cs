﻿namespace EasyBank.DTOs
{
    public class EmployeeDto
    {
        public required string FullName { get; set; }
        public required string Position { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public string? Phone { get; set; }
        public string? Role { get; set; }
    }
}
