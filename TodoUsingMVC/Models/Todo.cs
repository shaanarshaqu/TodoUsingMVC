using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoUsingMVC.Models
{
    public class Todo
    {
        [MaxLength(30)]
        public string Id { get; set; }
        [Required(ErrorMessage="sdad")]
        [DisplayName("Titieeeeeeeeee")]
        [MaxLength(30)]
        public string Title { get; set; }
        [MaxLength(30)]
        public string user_id { get; set; }
        public User user { get; set; }

    }
}
