using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerWApp.Models
{
    public class ProductDTO
    {
        public string? Name { get; set; }
        public string? Aciklama {get;set;}
        public decimal Price {get;set;} 
    }
}