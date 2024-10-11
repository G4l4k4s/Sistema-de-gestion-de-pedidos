using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaGestionPedidos.Data;
using SistemaGestionPedidos.Models;
using SistemaGestionPedidos.Repository;

namespace SistemaGestionPedidos.Services
{
    public class CategoryServices : ICategoryRepository
    {
        private readonly MyDbContext _context;


        public CategoryServices(MyDbContext context)
        {
            _context = context;
        }

        public async Task AddCategoryAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var ToDelete = await _context.Categories.FindAsync(id);
            if (ToDelete != null)
            {
                _context.Categories.Remove(ToDelete); 
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            _context.Entry(category).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<bool> CategoryExists(int id)
        {
            return await _context.Categories.AnyAsync(p => p.Id == id);
        }
    }
}