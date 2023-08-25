using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerWApp.Models
{
    public class Kitchen
    {
        public int KitchenId {get; set;}
        public string? KitchenAd {get;set;}
        public string? Images {get;set;}
        public List<Restorant>? Restorants {get;set;}
    }
}