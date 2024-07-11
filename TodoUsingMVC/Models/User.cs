using System.ComponentModel.DataAnnotations;

namespace TodoUsingMVC.Models
{
    public class User
    {
        [MaxLength(38)]
        public string Id { get; set; }
        [MaxLength(38)]
        public string UserName { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        public List<Todo> todos { get; set; }
    }
}
