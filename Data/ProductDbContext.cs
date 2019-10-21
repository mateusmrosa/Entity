using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;

namespace Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("Name=ProductDb")
        {
            Database.SetInitializer<ProductDbContext>(new CreateDatabaseIfNotExists<ProductDbContext>());
            Database.Initialize(false);
        }

        public DbSet<Produto> Produtos { set; get; }
        public DbSet<Loja> Lojas{ set; get; }
    }
}
