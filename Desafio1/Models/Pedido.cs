using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Desafio1.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public decimal Monto { get; set; }
        public decimal Total { get; set; }
    }
    public class PedidoDBContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
    }
}