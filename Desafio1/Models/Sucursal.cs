using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Desafio1.Models
{
    public class Sucursal
    {
        public int Id { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string Encargado { get; set; }
    }
    
}