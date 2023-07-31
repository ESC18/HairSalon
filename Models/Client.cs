using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public string Email { get; set; }

        public int StylistId { get; set; }
        public Stylist Stylist { get; set; }
    }
}
