using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WilesJacksonBugTracker.Repository.Domain;

namespace WilesJacksonBugTracker.App.Controllers
{
    public class LocationsController : Controller
    {
        private readonly BugContext _context;

        public LocationsController(BugContext context)
        {
            _context = context;
        }

        // GET: Locations
        public async Task<IActionResult> Index()
        {
            var bugContext = _context.Locations.Include(l => l.Tester);
            return View(await bugContext.ToListAsync());
        }

        // GET: Locations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locations = await _context.Locations
                .Include(l => l.Tester)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (locations == null)
            {
                return NotFound();
            }

            return View(locations);
        }

        // GET: Locations/Create
        public IActionResult Create()
        {
            ViewData["TesterId"] = new SelectList(_context.Testers, "Id", "FullName");
            return View();
        }

        // POST: Locations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TesterId,Name")] Locations locations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(locations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TesterId"] = new SelectList(_context.Testers, "Id", "FullName", locations.TesterId);
            return View(locations);
        }

        // GET: Locations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locations = await _context.Locations.FindAsync(id);
            if (locations == null)
            {
                return NotFound();
            }
            ViewData["TesterId"] = new SelectList(_context.Testers, "Id", "FullName", locations.TesterId);
            return View(locations);
        }

        // POST: Locations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TesterId,Name")] Locations locations)
        {
            if (id != locations.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(locations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocationsExists(locations.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["TesterId"] = new SelectList(_context.Testers, "Id", "FullName", locations.TesterId);
            return View(locations);
        }

        // GET: Locations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locations = await _context.Locations
                .Include(l => l.Tester)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (locations == null)
            {
                return NotFound();
            }

            return View(locations);
        }

        // POST: Locations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var locations = await _context.Locations.FindAsync(id);
            _context.Locations.Remove(locations);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocationsExists(int id)
        {
            return _context.Locations.Any(e => e.Id == id);
        }
    }
}
