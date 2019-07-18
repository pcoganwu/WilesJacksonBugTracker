using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WilesJacksonBugTracker.Repository.Domain;

namespace WilesJacksonBugTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [EnableCors("BugPolicy")]
    public class BugsController : ControllerBase
    {
        private readonly BugContext _context;

        public BugsController(BugContext context)
        {
            _context = context;
        }

        // GET: api/Bugs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bugs>>> GetBugs()
        {
            var bugContext = _context.Bugs.Include(b => b.BugPriority).Include(b => b.BugStatus).Include(b => b.Project);
           // return View(await bugContext.ToListAsync());
            return await _context.Bugs.ToListAsync();
        }

        // GET: api/Bugs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bugs>> GetBugs(int id)
        {
            var bugs = await _context.Bugs.FindAsync(id);

            if (bugs == null)
            {
                return NotFound();
            }

            return bugs;
        }

        // PUT: api/Bugs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBugs(int id, Bugs bugs)
        {
            if (id != bugs.Id)
            {
                return BadRequest();
            }

            _context.Entry(bugs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BugsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Bugs
        [HttpPost]
        public async Task<ActionResult<Bugs>> PostBugs(Bugs bugs)
        {
            _context.Bugs.Add(bugs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBugs", new { id = bugs.Id }, bugs);
        }

        // DELETE: api/Bugs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Bugs>> DeleteBugs(int id)
        {
            var bugs = await _context.Bugs.FindAsync(id);
            if (bugs == null)
            {
                return NotFound();
            }

            _context.Bugs.Remove(bugs);
            await _context.SaveChangesAsync();

            return bugs;
        }

        private bool BugsExists(int id)
        {
            return _context.Bugs.Any(e => e.Id == id);
        }
    }
}
