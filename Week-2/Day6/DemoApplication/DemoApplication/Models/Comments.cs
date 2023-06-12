using System.ComponentModel.DataAnnotations;

namespace DemoApplication.Models
{
    public class Comments
    {
        [Key]
        public string? UserName { get; set; }
        public string? CommentInfo { get; set; }
    }
}
