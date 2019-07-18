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
    public class BugPrioritiesController : Controller
    {
        private readonly BugContext _context;

        public BugPrioritiesController(BugContext context)
        {
            _context = context;
        }

        // GET: BugPriorities
        public async Task<IActionResult> Index()
        {
            return View(await _context.BugPriorities.ToListAsync());
        }

        // GET: BugPriorities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugPriorities = await _context.BugPriorities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bugPriorities == null)
            {
                return NotFound();
            }

            return View(bugPriorities);
        }

        // GET: BugPriorities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BugPriorities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BugPriorityType")] BugPriorities bugPriorities)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bugPriorities);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bugPriorities);
        }

        // GET: BugPriorities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugPriorities = await _context.BugPriorities.FindAsync(id);
            if (bugPriorities == null)
            {
                return NotFound();
            }
            return View(bugPriorities);
        }

        // POST: BugPriorities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BugPriorityType")] BugPriorities bugPriorities)
        {
            if (id != bugPriorities.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bugPriorities);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BugPrioritiesExists(bugPriorities.Id))
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
            return View(bugPriorities);
        }

        // GET: BugPriorities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugPriorities = await _context.BugPriorities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bugPriorities == null)
            {
                return NotFound();
            }

            return View(bugPriorities);
        }

        // POST: BugPriorities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bugPriorities = await _context.BugPriorities.FindAsync(id);
            _context.BugPriorities.Remove(bugPriorities);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BugPrioritiesExists(int id)
        {
            return _context.BugPriorities.Any(e => e.Id == id);
        }
    }
}
