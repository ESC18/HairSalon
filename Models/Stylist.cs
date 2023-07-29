using System.ComponentModel.DataAnnotations;
using HairSalon.Models;
using System.Collections.Generic;


namespace HairSalon.Models
{
    public class Stylist
    {
        public int StylistId { get; set; }
        public string StylistName { get; set; }
        public int Pay { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}
