using Microsoft.EntityFrameworkCore;
using VinorgiWineStore.Models;

namespace VinorgiWineStore.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected ApplicationDbContext()
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
