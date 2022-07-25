using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext() :base()
        {

        }
        public SqlServerContext(DbContextOptions<SqlServerContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => 
            options.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=geek_shopping_product_api; Integrated Security=False; MultipleActiveResultSets=true; User ID=sa;Password=33042917aA.");

    }
}

