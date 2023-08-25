using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServerWApp.Models;

namespace ServerWApp.Models
{
    public class FoodContext: IdentityDbContext<User,Role,int>
    {
        public FoodContext(DbContextOptions<FoodContext> options): base(options){

        }
        public DbSet<Product> Products {get; set;}
        public DbSet<Kitchen> Kitchens {get; set;}
        public DbSet<Restorant> Restorants {get; set;}
        public DbSet<Siparis> Siparisler {get; set;}
        
    }
}