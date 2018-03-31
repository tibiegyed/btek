using System.ComponentModel.DataAnnotations;

namespace btek.ViewModel
{
    public class AdPostViewModel
    {
        [Required]
        public string ClientName { get; set; }

        [Required]
        public string Address { get; set; }       

        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Email { get; set; }
    }
}