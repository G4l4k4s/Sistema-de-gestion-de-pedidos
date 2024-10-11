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
    public class CategoryGetController : CategoryController
    {
        public CategoryGetController(ICategoryRepository services) : base(services)
        {
        }

        [HttpGet]
        [SwaggerOperation(
            Summary = "Shows all existing category",
            Description = "show all the categories with the specified ID, if it exists, with the provided new details."
        )]
        [SwaggerResponse(204, "The category was successfully updated")]
        [SwaggerResponse(400, "If the provided category data is invalid")]
        [SwaggerResponse(404, "If the category with the specified ID     is not found")]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            var categories = await _services.GetCategoriesAsync();
            if (categories == null || !categories.Any())
            {
                return NoContent();
            }
            return Ok(categories);
        }


        [HttpGet("{id}")]
        [SwaggerOperation(
            Summary = "Show an existing spesify category",
            Description = "show the spesify category with the specified ID, if it exists, with the provided new details."
        )]
        [SwaggerResponse(204, "The category was successfully updated")]
        [SwaggerResponse(400, "If the provided category data is invalid")]
        [SwaggerResponse(404, "If the category with the specified ID     is not found")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            var category = await _services.GetCategoryByIdAsync(id);
            if (category == null)
            {
                return NotFound("Category " + id + " not found");
            }
            return Ok(category);
        }

    }
}