using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionPedidos.Models.Entitys;
using SistemaGestionPedidos.Repository;

namespace SistemaGestionPedidos.Controllers.v1.ProductsController
{
    [ApiController]
    [Route("api/v1/product")]
    [Tags("products")]
    public class ProductGetController : ProductController
    {
        public ProductGetController(IProductRepository services) : base(services)
        {
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var categories = await _services.GetAllProducts();
            if (categories == null || !categories.Any())
            {
                return NoContent();
            }
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductsById(int id)
        {
            var category = await _services.GetProductById(id);
            if (category == null)
            {
                return NotFound("Product " + id + " not found");
            }
            return Ok(category);
        }
    }
}