using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoUsingMVC.Models
{
    public class Todo
    {
        public string Id { get; set; }
        [Required(ErrorMessage="sdad")]
        [DisplayName("Titieeeeeeeeee")]
        public string Title { get; set; }
    }
}
