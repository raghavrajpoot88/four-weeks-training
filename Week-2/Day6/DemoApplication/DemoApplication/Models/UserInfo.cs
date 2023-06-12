using System.ComponentModel.DataAnnotations;

namespace DemoApplication.Models
{
    public class UserInfo
    {
        [Key]
        public string? UserName { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public string? DueDate { get; set; }
        public string? Priority { get; set; }

    }
}
