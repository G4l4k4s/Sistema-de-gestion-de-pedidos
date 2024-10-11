using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaGestionPedidos.Data;
using SistemaGestionPedidos.Models;
using SistemaGestionPedidos.Repository;
using Swashbuckle.AspNetCore.Annotations;

namespace SistemaGestionPedidos.Controllers.v1.CategoryControllers
{
    [ApiController]
    [Route("api/v1/category")]
    [Tags("category")]
    public class CategoryPostController : CategoryController
    {
        public CategoryPostController(ICategoryRepository services) : base(services)
        {
        }

        [HttpPost]
        [SwaggerOperation(
            Summary = "Create an category",
            Description = "creates an new category and save then in the database."
        )]
        [SwaggerResponse(204, "The category was successfully updated")]
        [SwaggerResponse(400, "If the provided category data is invalid")]
        [SwaggerResponse(404, "If the category with the specified ID     is not found")]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _services.AddCategoryAsync(category);
            return Ok("Category Created successfully");
        }
    }
}