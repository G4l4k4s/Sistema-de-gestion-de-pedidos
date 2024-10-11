using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaGestionPedidos.Data;
using SistemaGestionPedidos.Models.Entitys;
using SistemaGestionPedidos.Repository;

namespace SistemaGestionPedidos.Services
{
    public class ProductServices : IProductRepository
    {
        private readonly MyDbContext _context;

        public ProductServices(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task AddProduct(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(int id)
        {
            var ToDelete = await _context.Products.FindAsync(id);
            if (ToDelete != null)
            {
                _context.Products.Remove(ToDelete); 
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<bool> ProductExists(int id)
        {
            return await _context.Categories.AnyAsync(p => p.Id == id);
        }

        public async Task UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}