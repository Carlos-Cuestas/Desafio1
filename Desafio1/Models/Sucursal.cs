using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Desafio1.Models
{
    public class Sucursal
    {
        public int Id { get; set; }
   
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Departamento { get; set; }
    
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Municipio { get; set; }
      
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Encargado { get; set; }
    }
    
}