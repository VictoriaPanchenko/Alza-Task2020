using System;
using Microsoft.EntityFrameworkCore;
using AlzaApi.Models.v1_0;

namespace AlzaApi.Data
{
    /// <summary>
    /// Database context
    /// </summary>
    public class AlzaContext : DbContext
    {
        /// <inheritdoc />
        public AlzaContext (DbContextOptions<AlzaContext> options)
            : base(options)
        {
        }
        
        /// <summary>
        /// Table Products
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var random = new Random();
            var names = new[] {"Chair", "Car", "Computer", "Pants", "Shoes"};
            var adjectives = new[] {"Small", "Ergonomic", "Rustic", "Smart", "Sleek"};
            var materials = new[] {"Steel", "Wooden", "Concrete", "Plastic", "Granite", "Rubber"};

            for (int i = 1; i < 100; i++)
            {
                modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = i,
                        Name = names[random.Next(0, 5)],
                        ImgUri = Guid.NewGuid().ToString(),
                        Price = (decimal) random.Next(1000, 9000) / 100,
                        Description = $"{adjectives[random.Next(0, 5)]} {materials[random.Next(0, 5)]}",
                    }
                );
            }
        }
    }
}
