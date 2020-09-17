using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using msaPhase2.Data;
using msaPhase2.Models;

namespace msaPhase2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreboardController : ControllerBase
    {
        private readonly ScoreboardContext _context;

        public ScoreboardController(ScoreboardContext context)
        {
            _context = context;
        }

        // GET: api/Scoreboard
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Scoreboard>>> GetScoreboard()
        {
            return await _context.Scoreboard.ToListAsync();
        }

        // GET: api/Scoreboard/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Scoreboard>> GetScoreboard(int id)
        {
            var scoreboard = await _context.Scoreboard.FindAsync(id);

            if (scoreboard == null)
            {
                return NotFound();
            }

            return scoreboard;
        }

        // PUT: api/Scoreboard/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutScoreboard(int id, Scoreboard scoreboard)
        {
            if (id != scoreboard.scoreboardId)
            {
                return BadRequest();
            }

            _context.Entry(scoreboard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScoreboardExists(id))
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

        // POST: api/Scoreboard
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Scoreboard>> PostScoreboard(Scoreboard scoreboard)
        {
            _context.Scoreboard.Add(scoreboard);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetScoreboard", new { id = scoreboard.scoreboardId }, scoreboard);
        }

        // DELETE: api/Scoreboard/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Scoreboard>> DeleteScoreboard(int id)
        {
            var scoreboard = await _context.Scoreboard.FindAsync(id);
            if (scoreboard == null)
            {
                return NotFound();
            }

            _context.Scoreboard.Remove(scoreboard);
            await _context.SaveChangesAsync();

            return scoreboard;
        }

        private bool ScoreboardExists(int id)
        {
            return _context.Scoreboard.Any(e => e.scoreboardId == id);
        }
    }
}
