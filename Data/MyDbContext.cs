using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaGestionPedidos.Models;
using SistemaGestionPedidos.Models.Entitys;

namespace SistemaGestionPedidos.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            CategorySeeders.SeedCategories(modelBuilder);
            ProductSeeders.SeedProducts(modelBuilder);

        }

    }
}