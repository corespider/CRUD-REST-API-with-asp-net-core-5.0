using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductCoreService_DOTNET5.Models;

    public class ProductContext : DbContext
    {
        public ProductContext (DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<ProductCoreService_DOTNET5.Models.Product> Product { get; set; }
        public DbSet<ProductCoreService_DOTNET5.Models.User> User { get; set; }
}
