using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerWApp.Models
{
    public class Siparis
    {
        public int SiparisId { get; set; }
        public string? UrunName {get; set;}
        public decimal Price {get; set;}
        public string? SiparisDurumu {get; set;} 

    }
}