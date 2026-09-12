using Microsoft.EntityFrameworkCore;

namespace anket.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Katilimci> Katilimcilar { get; set; }

        
    }
}