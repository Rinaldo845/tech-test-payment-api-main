using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tech_test_payment_api.Models;
using Microsoft.EntityFrameworkCore;

namespace tech_test_payment_api.Context
{
  public class PottencialContext : DbContext
    {
        public PottencialContext(DbContextOptions<PottencialContext> options) : base(options)
        {

        }
        public DbSet<Pedido> Pedidos {get; set;}
        public DbSet<Vendedor> Vendedores {get; set;}
        public DbSet<Produto> Produtos {get; set; }
    }
}