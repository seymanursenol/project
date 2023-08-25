namespace ServerWApp.Models
{
    public class Product 
    { 

        public int ProductId { get; set;}
        public string? Name{get;set;}
        public decimal Price {get;set;} 
        public string? Aciklama { get; set; }
        public virtual Restorant? Restorant {get;set;}
        public int RestorantId {get;set;}
    }
}