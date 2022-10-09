using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using apiFutbol.Service;
using apiFutbol.model;

namespace apiFutbol.Controllers
{
    [ApiController]
    [Route("api/equipos/[controller]")]
    public class EquipoFutbolsController : Controller
    {
        private readonly FutbolDBContext _context;

        public EquipoFutbolsController(FutbolDBContext context)
        {
            _context = context;
        }



        // GET: api/FutbolDBEquipos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EquipoFutbol>>> GetFutbolDBEquipos()
        {
            return await _context.EquipoFutbol.ToListAsync();
        }

        // GET: api/FutbolDBEquipos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EquipoFutbol>> GetFutbolDBEquipos(int id)
        {
            var futbolDBEquipos = await _context.EquipoFutbol.FindAsync(id);

            if (futbolDBEquipos == null)
            {
                return NotFound();
            }

            return futbolDBEquipos;
        }

        // PUT: api/FutbolDBEquipos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFutbolDBEquipos(int id, EquipoFutbol futbolDBEquipos)
        {
            if (id != futbolDBEquipos.id)
            {
                return BadRequest();
            }

            _context.Entry(futbolDBEquipos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FutbolDBEquiposExists(id))
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

        // POST: api/FutbolDBEquipos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EquipoFutbol>> PostFutbolDBEquipos(EquipoFutbol futbolDBEquipos)
        {
            _context.EquipoFutbol.Add(futbolDBEquipos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFutbolDBEquipos", new { id = futbolDBEquipos.id }, futbolDBEquipos);
        }

        // DELETE: api/FutbolDBEquipos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFutbolDBEquipos(int id)
        {
            var futbolDBEquipos = await _context.EquipoFutbol.FindAsync(id);
            if (futbolDBEquipos == null)
            {
                return NotFound();
            }

            _context.EquipoFutbol.Remove(futbolDBEquipos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FutbolDBEquiposExists(int id)
        {
            return _context.EquipoFutbol.Any(e => e.id == id);
        }
    }
}
