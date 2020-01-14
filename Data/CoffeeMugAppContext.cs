using Microsoft.EntityFrameworkCore;
using CoffeeMugApp.Models;

namespace CoffeeMugApp.Data
{
    public class CoffeeMugAppContext : DbContext
    {
        public CoffeeMugAppContext (DbContextOptions<CoffeeMugAppContext> options): base(options){}

        public DbSet<Product> Product { get; set; }
    }
}