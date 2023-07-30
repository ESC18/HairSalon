using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class ClientsController : Controller
    {
        private readonly SalonContext _db;

        public ClientsController(SalonContext db)
        {
            _db = db;
        }

        public IActionResult Create(int stylistId)
        {
            var client = new Client();
            client.StylistSelectList = GetStylistSelectList();
            client.StylistId = stylistId;
            return View(client);
        }

        [HttpPost]
        public IActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                _db.Clients.Add(client);
                _db.SaveChanges();
                return RedirectToAction("Details", "Stylists", new { id = client.StylistId });
            }

            client.StylistSelectList = GetStylistSelectList();
            return View(client);
        }

        private List<SelectListItem> GetStylistSelectList()
        {
            return _db.Stylists
                .Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Name
                })
                .ToList();
        }
    }
}
