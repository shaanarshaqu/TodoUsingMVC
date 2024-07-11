using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoUsingMVC.Models
{
    public class Todo
    {
        [MaxLength(38)]
        public string Id { get; set; }
        [Required(ErrorMessage="sdad")]
        [DisplayName("Titieeeeeeeeee")]
        [MaxLength(38)]
        public string Title { get; set; }
        [MaxLength(38)]
        public string user_id { get; set; }
        public User user { get; set; }

    }
}
