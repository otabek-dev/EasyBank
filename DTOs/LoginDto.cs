﻿using System.ComponentModel.DataAnnotations;

namespace EasyBank.DTOs
{
    public class LoginDto
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
