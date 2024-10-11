using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGestionPedidos.Models
{
    public class CategoryDTO
    {  
        [Required(ErrorMessage = "El nombre de la categoría es requerido")]
        [MaxLength(50, ErrorMessage = "El nombre de la categoría no puede exceder los 50 caracteres")]
        public string Name { get; set; }
        [MaxLength(200, ErrorMessage = "La descripción de la categoría no puede exceder los 200 caracteres")]
        public string Description { get; set; }

    }
}