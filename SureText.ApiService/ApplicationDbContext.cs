using Microsoft.EntityFrameworkCore;

namespace SureText.ApiService;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{

    // Define your DbSets here
    // public DbSet<YourEntity> YourEntities { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Configure your entity mappings here
    }
}
