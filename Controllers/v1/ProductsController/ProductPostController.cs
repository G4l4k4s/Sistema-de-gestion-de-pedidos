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
    public class ProductPostController : ProductController
    {
        public ProductPostController(IProductRepository services) : base(services)
        {
        }


        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _services.AddProduct(product);
            return Ok("Product created successfully");
        }
    }
}