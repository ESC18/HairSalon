using Microsoft.EntityFrameworkCore;
using HairSalon.Models;


namespace HairSalon.Data
{
    public class SalonContext : DbContext
    {
        public DbSet<Stylist> Stylists { get; set; }
        public DbSet<Client> Clients { get; set; }
        
        public SalonContext(DbContextOptions<SalonContext> options) : base(options)
        {
        }
    }
}
