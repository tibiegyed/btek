using System.ComponentModel.DataAnnotations;

namespace btek.ViewModel
{
    public class AdPostViewModel
    {
        [Required(ErrorMessage = "Please Enter Your Name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Alphabetic value only.")]
        [StringLength(50, ErrorMessage = "Must be under 50 characters")]
        public string ClientName { get; set; }

        [Required(ErrorMessage = "Please Enter An Address")]
        public string Address { get; set; }       

        [Required(ErrorMessage = "Please Enter A Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please Enter A Price")]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        [Range(20, 1000, ErrorMessage = "Please Enter A Valid Price Range ($20 - $1000)")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Please Enter An Email")]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.a-z0-9-]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
    }
}