using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Desafio1.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Categoria { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public decimal PrecioVenta { get; set; }
    }

    
}