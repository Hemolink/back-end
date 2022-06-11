﻿using System;
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
    public class AgendaController : Controller
    {
        private readonly _DbContext _context;

        public AgendaController(_DbContext context)
        {
            _context = context;
        }

        // GET: api/Agenda
        [HttpGet]
        public async Task<ActionResult<List<Agenda>>> Getagenda()
        {
          if (_context.agenda == null)
          {
              return NotFound("There is no appointments...");
          }
            return await _context.agenda.ToListAsync();
        }

        // GET: api/Agenda/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Agenda>> GetAgenda(int id)
        {
          if (_context.agenda == null)
          {
              return NotFound("Appointment not found... ");
          }
            var agenda = await _context.agenda.FindAsync(id);

            if (agenda == null)
            {
                return NotFound();
            }

            return agenda;
        }

        // PUT: api/Agenda/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAgenda(int id, UpdateAgendaDto request)
        {
            var doador = await _context.doador.FindAsync(request.DoadorId);
            if (doador == null)
                return NotFound("Doador not found...");


            var newAgenda = new Agenda
            {
                IdAgendamento = request.IdAgendamento,
                DoadorId = request.DoadorId,
                Agendamento = request.Agendamento,
                Doador = doador,
            };


            if (id != newAgenda.IdAgendamento)
            {
                return BadRequest($"The id {id} is not the same on the JSON {newAgenda.IdAgendamento}...");
            }


            _context.Entry(newAgenda).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgendaExists(id))
                {
                    return NotFound("Appointment not found... ");
                }
                else
                {
                    throw;
                }
            }

            return Ok(newAgenda);
        }

        // POST: api/Agenda
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Agenda>> PostAgenda(CreateAgendaDto request)
        {

            var doador = await _context.doador.FindAsync(request.DoadorId);
            if (doador == null)
                return NotFound("Doador not found...");

            var newAgenda = new Agenda
            {
                DoadorId = request.DoadorId,
                Agendamento = request.Agendamento,
                Doador = doador,
            };

            if (_context.agenda == null)
            {
                return BadRequest("Agenda can't be null");
            }
            _context.agenda.Add(newAgenda);
            await _context.SaveChangesAsync();

            return Ok(newAgenda);
        }

        // DELETE: api/Agenda/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAgenda(int id)
        {
            if (_context.agenda == null)
            {
                return NotFound("Appointment not found... ");
            }
            var agenda = await _context.agenda.FindAsync(id);
            if (agenda == null)
            {
                return NotFound("Appointment not found... ");
            }

            _context.agenda.Remove(agenda);
            await _context.SaveChangesAsync();

            return Ok("Appontment succesfully deleted :) ");
        }

        private bool AgendaExists(int id)
        {
            return (_context.agenda?.Any(e => e.IdAgendamento == id)).GetValueOrDefault();
        }
    }
}