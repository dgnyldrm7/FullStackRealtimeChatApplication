﻿namespace App.Core.DTOs
{
    public class CreateUserDto
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
