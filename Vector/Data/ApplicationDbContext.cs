using Microsoft.EntityFrameworkCore;

namespace Vector.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Application> Applications { get; set; }
    }
}
