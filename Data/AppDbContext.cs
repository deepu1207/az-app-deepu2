using Microsoft.EntityFrameworkCore;

namespace az_app_deepu2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        // Define your DbSets here
        // public DbSet<YourEntity> YourEntities { get; set; }

        public DbSet<Person> Persons { get; set; } // Example DbSet for an entity named YourEntity
    }
}
