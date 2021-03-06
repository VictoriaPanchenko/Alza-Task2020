﻿using System;
using AlzaApi.Data;
using AlzaApi.Models.v1_0;

namespace AlzaApi.UnitTests.Data
{
    public static class DbContextExtensions
    {
        public static void Seed(this AlzaContext dbContext)
        {
            var random = new Random();
            var names = new[] { "Chair", "Coffee Machine", "Computer", "Keyboard", "Toy" };
            var adjectives = new[] { "Small", "Ergonomic", "Rustic", "Smart", "Sleek" };
            var materials = new[] { "Steel", "Wooden", "Concrete", "Plastic", "Granite", "Rubber" };

            for (int i = 1; i < 100; i++)
            {
                dbContext.Products.Add(
                    new Product
                    {
                        Id = i,
                        Name = names[random.Next(0, 5)],
                        ImgUri = Guid.NewGuid().ToString(),
                        Price = (decimal)random.Next(1000, 9000) / 100,
                        Description = $"{adjectives[random.Next(0, 5)]} {materials[random.Next(0, 5)]} {names[random.Next(0, 5)]}",
                    }
                );
            }

            dbContext.SaveChanges();
        }
    }
}
