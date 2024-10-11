using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionPedidos.Data;
using SistemaGestionPedidos.Models;
using SistemaGestionPedidos.Repository;
using Swashbuckle.AspNetCore.Annotations;

namespace SistemaGestionPedidos.Controllers.v1.CategoryControllers
{
    [ApiController]
    [Route("api/v1/category")]
    [Tags("category")]
    public class CategoryDeleteController : CategoryController
    {
        public CategoryDeleteController(ICategoryRepository context) : base(context)
        {
        }



        [HttpDelete("{id}")]
        [SwaggerOperation(
            Summary = "Deletes an existing category",
            Description = "Deletes the category with the specified ID, if it exists, with the provided new details."
        )]
        [SwaggerResponse(204, "The category was successfully updated")]
        [SwaggerResponse(400, "If the provided category data is invalid")]
        [SwaggerResponse(404, "If the category with the specified ID     is not found")]

        public async Task<ActionResult> DeleteCategory(int id)
        {
            var category = await _services.CategoryExists(id);
            if (category == false)
            {
                return BadRequest("Category does not exist");
            }
            else
            {
                await _services.DeleteCategoryAsync(id);
                return Ok("Category deleted successfully");
            }
        }



    }
}