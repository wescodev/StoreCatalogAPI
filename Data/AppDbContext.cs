using Microsoft.EntityFrameworkCore;
using StoreCatalogAPI.Models;

namespace StoreCatalogAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}
        public DbSet<Product> Produtos { get; set; }
        public DbSet<Category> Categorias { get; set; }
    }
}
