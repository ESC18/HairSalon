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

        // GET: Clients
        public ActionResult Index()
        {
            var model = _db.Clients.ToList();
            return View(model);
        }

        // GET: Clients/Create
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

        // POST: Clients/Create
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

            // If the model is not valid, regenerate the SelectList and return the view with validation errors
            var stylistSelectList = new SelectList(_db.Stylists, "Id", "Name");
            ViewBag.StylistSelectList = stylistSelectList;

            return View(client);
        }

        // GET: Clients/Details/5
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
