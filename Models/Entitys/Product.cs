using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SistemaGestionPedidos.Models.Entitys
{
    [Table("products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]

        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("quantity")]
        public decimal Quantity { get; set; }

        [Column("category_id")]
        public int CategoryId { get; set; }

        [JsonIgnore]
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}