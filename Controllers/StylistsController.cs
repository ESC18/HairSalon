using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class StylistsController : Controller
    {
        private readonly SalonContext _context;

        public StylistsController(SalonContext context)
        {
            _context = context;
        }

        // GET: Stylists
        public async Task<ActionResult> Index()
        {
            var stylists = await _context.Stylists.ToListAsync();
            return View(stylists);
        }

        // GET: Stylists/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stylist = await _context.Stylists
                .Include(s => s.Clients)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (stylist == null)
            {
                return NotFound();
            }

            return View(stylist);
        }

        // GET: Stylists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stylists/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Name,Specialty")] Stylist stylist)
        {
            if (ModelState.IsValid)
            {
                _context.Stylists.Add(stylist);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(stylist);
        }

    }
}
