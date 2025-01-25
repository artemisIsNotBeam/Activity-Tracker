using Microsoft.EntityFrameworkCore;

namespace Activity_Tracker.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./ActivityTracker.sqlite");
        }
        public DbSet<Activity> Activities { get; set; }
    }
}
