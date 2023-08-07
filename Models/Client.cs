using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        public string? Email { get; set; }

        public int StylistId { get; set; }
        public Stylist Stylist { get; set; }
    }
}
