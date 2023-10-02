using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace Example01.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
   

    // DbContext => 

    public class ProductDbContext : DbContext
    {
        //public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        //{
        //}

        public ProductDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLExpress; database=productdb; integrated security = true; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Product> Products { get; set; }

    }


}
