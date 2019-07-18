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
    public class TestersController : Controller
    {
        private readonly BugContext _context;

        public TestersController(BugContext context)
        {
            _context = context;
        }

        // GET: Testers
        public async Task<IActionResult> Index()
        {
            var bugContext = _context.Testers.Include(t => t.Project);
            return View(await bugContext.ToListAsync());
        }

        // GET: Testers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testers = await _context.Testers
                .Include(t => t.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testers == null)
            {
                return NotFound();
            }

            return View(testers);
        }

        // GET: Testers/Create
        public IActionResult Create()
        {
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Name");
            ViewData["TesterId"] = new SelectList(_context.Projects, "Id", "FullName");
            return View();
        }

        // POST: Testers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProjectId,FirstName,LastName")] Testers testers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Name", testers.ProjectId);
            return View(testers);
        }

        // GET: Testers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testers = await _context.Testers.FindAsync(id);
            if (testers == null)
            {
                return NotFound();
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Name", testers.ProjectId);
            return View(testers);
        }

        // POST: Testers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProjectId,FirstName,LastName")] Testers testers)
        {
            if (id != testers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestersExists(testers.Id))
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
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Name", testers.ProjectId);
            return View(testers);
        }

        // GET: Testers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testers = await _context.Testers
                .Include(t => t.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testers == null)
            {
                return NotFound();
            }

            return View(testers);
        }

        // POST: Testers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testers = await _context.Testers.FindAsync(id);
            _context.Testers.Remove(testers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestersExists(int id)
        {
            return _context.Testers.Any(e => e.Id == id);
        }
    }
}
