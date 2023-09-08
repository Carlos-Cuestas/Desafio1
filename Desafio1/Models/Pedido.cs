using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Desafio1.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        [Display(Name = "Fecha de lanzamiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public decimal Monto { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public decimal Total { get; set; }

        
        public int? clienteid { get; set; }
        public virtual Cliente clientes { get; set; }
    }
    
}