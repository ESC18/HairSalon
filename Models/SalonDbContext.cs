using Microsoft.EntityFrameworkCore;

namespace HairSalon.Data
{
    public class SalonDbContext : DbContext
    {
        public DbSet<Stylist> Stylists { get; set; }
        public DbSet<Client> Clients { get; set; }
        public HairSalonDbContext(DbContextOptions<HairSalonDbContext> options) : base(options)
        {
        }
    }
}