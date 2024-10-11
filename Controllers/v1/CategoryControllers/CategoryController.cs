using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaGestionPedidos.Data;
using SistemaGestionPedidos.Models;
using SistemaGestionPedidos.Repository;

namespace SistemaGestionPedidos.Controllers.v1.CategoryControllers
{
    [ApiController]
    [Route("api/v1/category")]
    [Tags("category")]
    public class CategoryController : ControllerBase
    {
        public readonly ICategoryRepository _services;

        public CategoryController(ICategoryRepository services)
        {
            _services = services;
        }
    }
}