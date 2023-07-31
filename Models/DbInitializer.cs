using System;
using System.Linq;

namespace HairSalon.Models
{
    public static class DbInitializer
    {
        public static void Initialize(SalonContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
