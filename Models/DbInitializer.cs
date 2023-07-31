using System;
using System.Linq;

namespace HairSalon.Models
{
    public static class DbInitializer
    {
        public static void Initialize(SalonContext context)
        {
            // Ensure the database is created, but don't perform any seeding
            context.Database.EnsureCreated();
        }
    }
}
