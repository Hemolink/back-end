﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hemolink.Models;
using Hemolink.Data;

namespace Hemolink.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionarioController : Controller
    {
        private readonly _DbContext _context;

        public QuestionarioController(_DbContext context)
        {
            _context = context;
        }

        // GET: api/Questionario
        [HttpGet]
        public async Task<ActionResult<List<Questionario>>> Getquestionario()
        {
          if (_context.questionario == null)
          {
              return NotFound();
          }
            return await _context.questionario.ToListAsync();
        }

        // GET: api/Questionario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Questionario>> GetQuestionario(int id)
        {
          if (_context.questionario == null)
          {
              return NotFound();
          }
            var questionario = await _context.questionario.FindAsync(id);

            if (questionario == null)
            {
                return NotFound();
            }

            return questionario;
        }

        // PUT: api/Questionario/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult> PutQuestionario(int id, Questionario questionario)
        {
            if (id != questionario.IdFormulario)
            {
                return BadRequest();
            }

            _context.Entry(questionario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionarioExists(id))
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

        // POST: api/Questionario
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Questionario>> PostQuestionario(Questionario questionario)
        {
          if (_context.questionario == null)
          {
              return Problem("Entity set '_DbContext.questionario'  is null.");
          }
            _context.questionario.Add(questionario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuestionario", new { id = questionario.IdFormulario }, questionario);
        }

        // DELETE: api/Questionario/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteQuestionario(int id)
        {
            if (_context.questionario == null)
            {
                return NotFound();
            }
            var questionario = await _context.questionario.FindAsync(id);
            if (questionario == null)
            {
                return NotFound();
            }

            _context.questionario.Remove(questionario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool QuestionarioExists(int id)
        {
            return (_context.questionario?.Any(e => e.IdFormulario == id)).GetValueOrDefault();
        }
    }
}
