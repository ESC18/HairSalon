using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class StylistsController : Controller
    {
        private readonly SalonContext _db;

        public StylistsController(SalonContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var model = _db.Stylists.ToList();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var stylist = _db.Stylists.Include(s => s.Clients).FirstOrDefault(s => s.Id == id);


            return View(stylist);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Stylist stylist)
        {

            _db.Stylists.Add(stylist);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Edit(int id)
        {
            var stylist = _db.Stylists.Find(id);
            return View(stylist);
        }

        [HttpPost]
        public IActionResult Edit(Stylist stylist)
        {
            _db.Entry(stylist).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            var stylist = _db.Stylists.Find(id);

            return View(stylist);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var stylist = _db.Stylists.Find(id);

            _db.Stylists.Remove(stylist);
            _db.SaveChanges();


            return RedirectToAction("Index");
        }
    }
}
