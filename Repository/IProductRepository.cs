using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaGestionPedidos.Models.Entitys;

namespace SistemaGestionPedidos.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(int id);
        Task<bool> ProductExists(int id);

    }
}