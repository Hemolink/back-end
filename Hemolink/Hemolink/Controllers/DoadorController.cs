using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hemolink.Models;

namespace Hemolink.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoadorController : ControllerBase
    {
        private readonly _DbContext _context;

        public DoadorController(_DbContext context)
        {
            _context = context;
        }

        // GET: api/Doador
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Doador>>> Getdoador()
        {
          if (_context.doador == null)
          {
              return NotFound();
          }
            return await _context.doador.ToListAsync();
        }

        // GET: api/Doador/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Doador>> GetDoador(int id)
        {
          if (_context.doador == null)
          {
              return NotFound();
          }
            var doador = await _context.doador.FindAsync(id);

            if (doador == null)
            {
                return NotFound();
            }

            return doador;
        }

        // PUT: api/Doador/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDoador(int id, Doador doador)
        {
            if (id != doador.IdDoador)
            {
                return BadRequest();
            }

            _context.Entry(doador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DoadorExists(id))
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

        // POST: api/Doador
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Doador>> PostDoador(Doador doador)
        {
          if (_context.doador == null)
          {
              return Problem("Entity set '_DbContext.doador'  is null.");
          }
            _context.doador.Add(doador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDoador", new { id = doador.IdDoador }, doador);
        }

        // DELETE: api/Doador/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoador(int id)
        {
            if (_context.doador == null)
            {
                return NotFound();
            }
            var doador = await _context.doador.FindAsync(id);
            if (doador == null)
            {
                return NotFound();
            }

            _context.doador.Remove(doador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DoadorExists(int id)
        {
            return (_context.doador?.Any(e => e.IdDoador == id)).GetValueOrDefault();
        }
    }
}
