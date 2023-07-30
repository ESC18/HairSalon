using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HairSalon.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

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
         [NotMapped]
        public List<SelectListItem> StylistSelectList { get; set; }
    }
}
