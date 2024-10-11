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
    public class ProductPutController : ProductController
    {
        public ProductPutController(IProductRepository services) : base(services)
        {
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _services.UpdateProduct(product);
            return Ok("Product changed successfully");
        }        
    }
}