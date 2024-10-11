using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGestionPedidos.Models.DTOs
{
    public class ProductDTO
    {
        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "La descripción no puede exceder los 500 caracteres.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio.")]
        [Range(0.01, 10000.00, ErrorMessage = "El precio debe estar entre 0.01 y 10,000.00.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "La cantidad es obligatoria.")]
        [Range(1, 10000, ErrorMessage = "La cantidad debe estar entre 1 y 10,000.")]
        public decimal Quantity { get; set; }

        // [Required(ErrorMessage = "El ID de la categoría es obligatorio.")]
        [Required]
        public int CategoryId { get; set; }

    }
}