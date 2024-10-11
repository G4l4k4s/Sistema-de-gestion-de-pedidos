using SistemaGestionPedidos.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SistemaGestionPedidos.Data
{
    public class CategorySeeders
    {
        public static void SeedCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Bebidas", Description = "Bebidas frías y calientes" },
                new Category { Id = 2, Name = "Postres", Description = "Dulces y postres variados" },
                new Category { Id = 3, Name = "Entradas", Description = "Aperitivos y entradas ligeras" },
                new Category { Id = 4, Name = "Ensaladas", Description = "Ensaladas frescas y saludables" },
                new Category { Id = 5, Name = "Pastas", Description = "Variedad de pastas italianas" },
                new Category { Id = 6, Name = "Carnes", Description = "Platos a base de carne" },
                new Category { Id = 7, Name = "Pescados y Mariscos", Description = "Platos de mariscos frescos" },
                new Category { Id = 8, Name = "Vegetariano", Description = "Opciones vegetarianas y veganas" },
                new Category { Id = 9, Name = "Comida Rápida", Description = "Hamburguesas, pizzas y más" },
                new Category { Id = 10, Name = "Sopas", Description = "Sopas y caldos variados" }
            );
        }
    }
}
