
using Day2ApplicationMB.Controllers;
using System.ComponentModel.DataAnnotations;

namespace Day2ApplicationMB.Models
{
    public class Products
    {
        [Required(ErrorMessage ="Plaese enter valid number")]
        [Range(0, double.MaxValue, ErrorMessage = "The Price field must be a positive number.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Invalid")]
        public  string? Name { get; set; }
        [Required(ErrorMessage = "Plaese enter valid number")]
        [Range(0, double.MaxValue, ErrorMessage = "The Price field must be a positive number.")]
        public int Price { get; set; }

    }
}
