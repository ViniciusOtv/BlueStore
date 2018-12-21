using LojaVirtual.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LojaVirtual.DAL
{
    public class ApplicationDbContext : IdentityDbContext<Usuario>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<Produto> Produtos { get; set; }
        public IDbSet<Categoria> Categorias { get; set; }
        public IDbSet<Pedido> Pedidos { get; set; }
        public IDbSet<ItemPedido> ItemPedidos { get; set; }

    }
   

}