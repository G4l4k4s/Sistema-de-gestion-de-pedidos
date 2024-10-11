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
    public class ProductController : ControllerBase
    {
        public readonly IProductRepository _services;

        public ProductController(IProductRepository services)
        {
            _services = services;
        }








        
    }
}