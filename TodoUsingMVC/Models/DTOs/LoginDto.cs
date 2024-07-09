using System.ComponentModel;

namespace TodoUsingMVC.Models.DTOs
{
    public class LoginDto
    {
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}
