using System;
using System.ComponentModel.DataAnnotations;

namespace btek.Models
{
    public class AdPostModel
    {
        [Key]
        public int AdId { get; set; }

        public string ClientName { get; set; }
        
        public string Address { get; set; }
        
        public DateTime Date { get; set; }
       
        public string Description { get; set; }

        public double Price {get;set;}

        public string Email { get; set; }
    }
}