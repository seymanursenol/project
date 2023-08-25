using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerWApp.Models
{
    public class Restorant
    {
        public int RestorantId { get; set; }
        public string? RestorantName { get; set; }

        public string? RestorantAdres { get; set; }

        public string? RestSahibiFullName { get; set; }

        public string? RestAciklama { get; set; }
        public string? RestSahibiEMail { get; set; }
        public string? RestorantEMail { get; set; }
        public string? RestSahibiPhone {get; set;}
        public string? Dakika {get; set;}
        public string? Parola {get; set;}
        public string? Image {get; set;}
        public int KitchenId {get;set;}
        public string? KitchenName {get;set;}
        public virtual Kitchen? Kitchen{ get; set;}

        
    }
}