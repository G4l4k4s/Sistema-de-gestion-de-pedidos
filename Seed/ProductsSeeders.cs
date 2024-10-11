using SistemaGestionPedidos.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SistemaGestionPedidos.Models.Entitys;

namespace SistemaGestionPedidos.Data
{
    public class ProductSeeders
    {
        public static void SeedProducts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Café", Description = "Café negro caliente", Price = 2.50m, Quantity = 100, CategoryId = 1 },
                new Product { Id = 2, Name = "Hamburguesa", Description = "Hamburguesa clásica con queso", Price = 8.99m, Quantity = 50, CategoryId = 9 },
                new Product { Id = 3, Name = "Ensalada César", Description = "Ensalada fresca con aderezo César", Price = 6.50m, Quantity = 30, CategoryId = 4 },
                new Product { Id = 4, Name = "Pizza Margherita", Description = "Pizza tradicional italiana", Price = 12.00m, Quantity = 25, CategoryId = 9 },
                new Product { Id = 5, Name = "Tarta de Manzana", Description = "Tarta de manzana casera", Price = 4.00m, Quantity = 40, CategoryId = 2 },
                new Product { Id = 6, Name = "Pasta Alfredo", Description = "Pasta con salsa Alfredo y pollo", Price = 9.75m, Quantity = 20, CategoryId = 5 },
                new Product { Id = 7, Name = "Filete de Salmón", Description = "Salmón fresco a la parrilla", Price = 15.99m, Quantity = 15, CategoryId = 7 },
                new Product { Id = 8, Name = "Sopa de Tomate", Description = "Sopa caliente de tomate", Price = 3.25m, Quantity = 35, CategoryId = 10 },
                new Product { Id = 9, Name = "Sandwich Vegetariano", Description = "Sandwich de vegetales frescos", Price = 5.50m, Quantity = 45, CategoryId = 8 },
                new Product { Id = 10, Name = "Jugo de Naranja", Description = "Jugo natural de naranja", Price = 2.00m, Quantity = 60, CategoryId = 1 }
            );
        }
    }
}
