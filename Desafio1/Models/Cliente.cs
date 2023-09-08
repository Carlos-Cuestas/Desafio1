using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Desafio1.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
    public class ClienteDBContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set;}
    }
}