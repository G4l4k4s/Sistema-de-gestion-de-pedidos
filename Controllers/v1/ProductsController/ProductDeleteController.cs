using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionPedidos.Repository;

namespace SistemaGestionPedidos.Controllers.v1.ProductsController
{
    [ApiController]
    [Route("api/v1/product")]
    [Tags("products")]
    public class ProductDeleteController : ProductController
    {
        public ProductDeleteController(IProductRepository services) : base(services)
        {
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            var category = await _services.ProductExists(id);
            if (category == false)
            {
                return BadRequest("Product does not exist");
            }
            else
            {
                await _services.DeleteProduct(id);
                return Ok("Product deleted successfully");
            }
        }

    }
}