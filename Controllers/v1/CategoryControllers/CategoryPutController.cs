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
    public class CategoryPutController : CategoryController
    {
        public CategoryPutController(ICategoryRepository context) : base(context)
        {
        }

        [HttpPut("{id}")]
        [SwaggerOperation(
            Summary = "Updates an existing category",
            Description = "Updates the category with the specified ID, if it exists, with the provided new details."
        )]
        [SwaggerResponse(204, "The category was successfully updated")]
        [SwaggerResponse(400, "If the provided category data is invalid")]
        [SwaggerResponse(404, "If the category with the specified ID     is not found")]
        public async Task<IActionResult> PutCategory(int id, Category category)
        {
            if (id != category.Id)
            {
                return BadRequest();
            }

            _services.UpdateCategoryAsync(category);
            return Ok("Category changed successfully");
        }

    }
}