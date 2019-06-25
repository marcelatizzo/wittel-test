using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web.API.Models
{
    public class WittelDBContext : DbContext
    {
        public WittelDBContext() : base()
        { }

        public DbSet<Product> Produtos { get; set; }

        public DbSet<User> Usuarios { get; set; }

        public DbSet<Order> Pedidos { get; set; }

        public DbSet<OrderItem> ItensPedido { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}