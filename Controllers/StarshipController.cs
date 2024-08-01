using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarWarsAPI.Data;
using StarWarsAPI.Models;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI.Controllers
{
    public class StarshipsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StarshipsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Starships
        public async Task<IActionResult> Index()
        {
            var count = await _context.Starships.CountAsync();
            if (count == 0)
            {
                return View(null); // No starships available
            }

            var random = new Random();
            var randomStarship = await _context.Starships
                .Skip(random.Next(count))
                .FirstOrDefaultAsync();

            return View(randomStarship);
        }

        // GET: Starships/List
        public async Task<IActionResult> List()
        {
            var starships = await _context.Starships.ToListAsync();
            return View(starships);
        }

        // GET: Starships/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var starship = await _context.Starships
                .FirstOrDefaultAsync(m => m.Id == id);

            if (starship == null)
            {
                return NotFound();
            }

            return View(starship);
        }

        // GET: Starships/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Starships/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Model,Manufacturer,CostInCredits,Crew,Passengers,StarshipClass")] Starship starship)
        {
            if (ModelState.IsValid)
            {
                _context.Add(starship);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(starship);
        }

        // GET: Starships/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var starship = await _context.Starships.FindAsync(id);
            if (starship == null)
            {
                return NotFound();
            }
            return View(starship);
        }

        // POST: Starships/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Model,Manufacturer,CostInCredits,Crew,Passengers,StarshipClass")] Starship starship)
        {
            if (id != starship.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(starship);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StarshipExists(starship.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(List));
            }
            return View(starship);
        }

        // GET: Starships/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var starship = await _context.Starships
                .FirstOrDefaultAsync(m => m.Id == id);

            if (starship == null)
            {
                return NotFound();
            }

            return View(starship);
        }

        // POST: Starships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var starship = await _context.Starships.FindAsync(id);
            if (starship == null)
            {
                return NotFound();
            }

            _context.Starships.Remove(starship);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(List));
        }

        private bool StarshipExists(int id)
        {
            return _context.Starships.Any(e => e.Id == id);
        }
    }
}
