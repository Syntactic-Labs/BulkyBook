using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder) { }
        public DbSet<User> Users { get; set; }
    }
}
