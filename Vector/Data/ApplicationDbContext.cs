using Microsoft.EntityFrameworkCore;

namespace Vector.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Application> Applications { get; set; }
        public DbSet<ApplicationStatus> ApplicationStatus { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationStatus>().HasData(
                new ApplicationStatus { Id = 1, Name = "Interested", SortOrder = 1 },
                new ApplicationStatus { Id = 2, Name = "Applied", SortOrder = 2 },
                new ApplicationStatus { Id = 3, Name = "Interviewing", SortOrder = 3 },
                new ApplicationStatus { Id = 4, Name = "Rejected", SortOrder = 4 }
            );
        }
    }
}
