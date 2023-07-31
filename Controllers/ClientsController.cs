using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class ClientsController : Controller
    {
        private SalonContext _db;

        public ClientsController(SalonContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var model = _db.Clients.ToList();
            return View(model);
        }
        public ActionResult Create(int? stylistId)
        {
            if (stylistId.HasValue)
            {
                var stylist = _db.Stylists.Find(stylistId);
                if (stylist == null)
                {
                    return NotFound();
                }

                ViewBag.StylistId = stylist.Id;
            }
            else
            {
                var stylistSelectList = new SelectList(_db.Stylists, "Id", "Name");
                ViewBag.StylistSelectList = stylistSelectList;
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                _db.Clients.Add(client);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            var stylistSelectList = new SelectList(_db.Stylists, "Id", "Name");
            ViewBag.StylistSelectList = stylistSelectList;

            return View(client);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var client = _db.Clients.FirstOrDefault(c => c.Id == id);

            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }
    }
}
