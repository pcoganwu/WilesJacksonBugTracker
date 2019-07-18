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
    public class BugStatusesController : Controller
    {
        private readonly BugContext _context;

        public BugStatusesController(BugContext context)
        {
            _context = context;
        }

        // GET: BugStatuses
        public async Task<IActionResult> Index()
        {
            return View(await _context.BugStatuses.ToListAsync());
        }

        // GET: BugStatuses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugStatuses = await _context.BugStatuses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bugStatuses == null)
            {
                return NotFound();
            }

            return View(bugStatuses);
        }

        // GET: BugStatuses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BugStatuses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BugStatusType")] BugStatuses bugStatuses)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bugStatuses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bugStatuses);
        }

        // GET: BugStatuses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugStatuses = await _context.BugStatuses.FindAsync(id);
            if (bugStatuses == null)
            {
                return NotFound();
            }
            return View(bugStatuses);
        }

        // POST: BugStatuses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BugStatusType")] BugStatuses bugStatuses)
        {
            if (id != bugStatuses.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bugStatuses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BugStatusesExists(bugStatuses.Id))
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
            return View(bugStatuses);
        }

        // GET: BugStatuses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugStatuses = await _context.BugStatuses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bugStatuses == null)
            {
                return NotFound();
            }

            return View(bugStatuses);
        }

        // POST: BugStatuses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bugStatuses = await _context.BugStatuses.FindAsync(id);
            _context.BugStatuses.Remove(bugStatuses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BugStatusesExists(int id)
        {
            return _context.BugStatuses.Any(e => e.Id == id);
        }
    }
}
