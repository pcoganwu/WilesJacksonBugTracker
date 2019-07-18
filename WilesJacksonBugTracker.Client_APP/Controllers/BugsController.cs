using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WilesJacksonBugTracker.Client_APP.Helper;
using WilesJacksonBugTracker.Repository.Domain;

namespace WilesJacksonBugTracker.Client_APP.Controllers
{
    public class BugsController : Controller
    {
        HttpClient Client;
        string URL = "http://localhost:5001";

        private readonly BugContext _context;

        public BugsController(BugContext context)
        {
            _context = context;
        }

        // GET: Bugs
        public async Task<IActionResult> Index()
        {

            var bugContext = _context.Bugs.Include(b => b.BugPriority).Include(b => b.BugStatus).Include(b => b.Project);
            return View(await bugContext.ToListAsync());
        }

        // GET: Bugs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugs = await _context.Bugs
                .Include(b => b.BugPriority)
                .Include(b => b.BugStatus)
                .Include(b => b.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bugs == null)
            {
                return NotFound();
            }

            return View(bugs);
        }

        // GET: Bugs/Create
        public IActionResult Create()
        {
            ViewData["BugPriorityId"] = new SelectList(_context.BugPriorities, "Id", "BugPriorityType");
            ViewData["BugStatusId"] = new SelectList(_context.BugStatuses, "Id", "BugStatusType");
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Description");
            return View();
        }

        // POST: Bugs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProjectId,BugPriorityId,BugStatusId,BugCreatedBy,BugCreatedOn,BugClosedBy,BugClosedOn,BugResolutionSummary")] Bugs bugs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bugs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BugPriorityId"] = new SelectList(_context.BugPriorities, "Id", "BugPriorityType", bugs.BugPriorityId);
            ViewData["BugStatusId"] = new SelectList(_context.BugStatuses, "Id", "BugStatusType", bugs.BugStatusId);
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Description", bugs.ProjectId);
            return View(bugs);

            //using (HttpClient client = new HttpClient())
            //{
            //    //instructor.Id = "0";
            //    client.BaseAddress = new Uri("https://localhost:5001");
            //    string stringData = JsonConvert.SerializeObject(bugs);
            //    var contentData = new StringContent(stringData,
            //                             System.Text.Encoding.UTF8,
            //                             "application/json");
            //    HttpResponseMessage response =
            //        client.PostAsync("/api/bugs", contentData)
            //              .Result;
            //    var status = response.StatusCode; //should be 201
            //    //ViewBag.Message = response.Content.ReadAsStringAsync().Result;
            //    return RedirectToAction(nameof(Index));
        //}
        }

        // GET: Bugs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugs = await _context.Bugs.FindAsync(id);
            if (bugs == null)
            {
                return NotFound();
            }
            ViewData["BugPriorityId"] = new SelectList(_context.BugPriorities, "Id", "BugPriorityType", bugs.BugPriorityId);
            ViewData["BugStatusId"] = new SelectList(_context.BugStatuses, "Id", "BugStatusType", bugs.BugStatusId);
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Description", bugs.ProjectId);
            return View(bugs);
        }

        // POST: Bugs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProjectId,BugPriorityId,BugStatusId,BugCreatedBy,BugCreatedOn,BugClosedBy,BugClosedOn,BugResolutionSummary")] Bugs bugs)
        {
            if (id != bugs.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bugs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BugsExists(bugs.Id))
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
            ViewData["BugPriorityId"] = new SelectList(_context.BugPriorities, "Id", "BugPriorityType", bugs.BugPriorityId);
            ViewData["BugStatusId"] = new SelectList(_context.BugStatuses, "Id", "BugStatusType", bugs.BugStatusId);
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Description", bugs.ProjectId);
            return View(bugs);
        }

        // GET: Bugs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugs = await _context.Bugs
                .Include(b => b.BugPriority)
                .Include(b => b.BugStatus)
                .Include(b => b.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bugs == null)
            {
                return NotFound();
            }

            return View(bugs);
        }

        // POST: Bugs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bugs = await _context.Bugs.FindAsync(id);
            _context.Bugs.Remove(bugs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BugsExists(int id)
        {
            return _context.Bugs.Any(e => e.Id == id);
        }
    }
}
