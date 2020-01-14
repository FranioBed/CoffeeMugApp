using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CoffeeMugApp.Data;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeMugApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CoffeeMugAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<CoffeeMugAppContext>>()
            ))
            {
                if(context.Product.Any())
                {
                    return;         //Database has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        Name = "Box of cookies",
                        Price = 2.00M
                    },
                    new Product
                    {
                        Name = "Frozen pizza",
                        Price = 8.00M
                    },
                    new Product
                    {
                        Name = "Pasta",
                        Price = 3.00M
                    },
                    new Product
                    {
                        Name = "Hamburger",
                        Price = 5.00M
                    },
                    new Product
                    {
                        Name = "Bubblegum",
                        Price = 1.00M
                    }
                );
                context.SaveChanges();
            }
        }
    }

    public class Product
    {
        [Column(TypeName="guid")]
        public Guid Id { get; set; }
        [Required]
        [Column(TypeName="nvarchar(100)")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName="decimal")]
        public decimal Price { get; set; }
    }

    
}