using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace btek.Models
{
    public class AdPostModel
    {
        public string ClientName { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Price {get;set;}
    }
}