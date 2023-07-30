using System.ComponentModel.DataAnnotations;
using HairSalon.Models;
using System.Collections.Generic;


namespace HairSalon.Models
{
public class Stylist
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    public List<Client> Clients { get; set; }
}

}
