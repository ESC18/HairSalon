using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
    public class Stylist
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string? Name { get; set; } 

        [Required(ErrorMessage = "Specialty is required.")]
        public string? Specialty { get; set; } 

        public List<Client> Clients { get; set; }
    }


}
