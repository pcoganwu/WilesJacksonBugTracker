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
    public class ProjectAccessesController : Controller
    {
        private readonly BugContext _context;

        public ProjectAccessesController(BugContext context)
        {
            _context = context;
        }

        // GET: ProjectAccesses
        public async Task<IActionResult> Index()
        {
            var bugContext = _context.ProjectAccesses.Include(p => p.Project);
            return View(await bugContext.ToListAsync());
        }

        // GET: ProjectAccesses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectAccesses = await _context.ProjectAccesses
                .Include(p => p.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectAccesses == null)
            {
                return NotFound();
            }

            return View(projectAccesses);
        }

        // GET: ProjectAccesses/Create
        public IActionResult Create()
        {
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Name");
            return View();
        }

        // POST: ProjectAccesses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProjectId,FirstName,LastName")] ProjectAccesses projectAccesses)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectAccesses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Name", projectAccesses.ProjectId);
            return View(projectAccesses);
        }

        // GET: ProjectAccesses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectAccesses = await _context.ProjectAccesses.FindAsync(id);
            if (projectAccesses == null)
            {
                return NotFound();
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Name", projectAccesses.ProjectId);
            return View(projectAccesses);
        }

        // POST: ProjectAccesses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProjectId,FirstName,LastName")] ProjectAccesses projectAccesses)
        {
            if (id != projectAccesses.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectAccesses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectAccessesExists(projectAccesses.Id))
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
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Name", projectAccesses.ProjectId);
            return View(projectAccesses);
        }

        // GET: ProjectAccesses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectAccesses = await _context.ProjectAccesses
                .Include(p => p.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectAccesses == null)
            {
                return NotFound();
            }

            return View(projectAccesses);
        }

        // POST: ProjectAccesses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectAccesses = await _context.ProjectAccesses.FindAsync(id);
            _context.ProjectAccesses.Remove(projectAccesses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectAccessesExists(int id)
        {
            return _context.ProjectAccesses.Any(e => e.Id == id);
        }
    }
}
