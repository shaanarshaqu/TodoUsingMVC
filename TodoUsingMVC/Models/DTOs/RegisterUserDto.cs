﻿using System.ComponentModel.DataAnnotations;

namespace TodoUsingMVC.Models.DTOs
{
    public class RegisterUserDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
