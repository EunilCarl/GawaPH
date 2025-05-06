using Microsoft.EntityFrameworkCore;

namespace GawaPH.Models
{
    public class GawaPHContext : DbContext
    {
        public GawaPHContext(DbContextOptions<GawaPHContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<JobPost> JobPosts { get; set; }
        public DbSet<Bid> Bids { get; set; }
    }
}
