using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Desafio1.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Categoria { get; set; }
        public decimal PrecioVenta { get; set; }
    }

    
}