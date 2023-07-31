using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
public class SalonContext : DbContext
{
    public SalonContext(DbContextOptions<SalonContext> options) : base(options)
    {
    }

    public DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }
}

}
