using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hemolink.Models;
using Hemolink.Data;
using Hemolink.Data.Dtos.Agenda;

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

        [HttpGet]
        public ActionResult<List<DateTime>> GetAvailableHours(DateTime? date)
        {
            if (_context.agenda == null)
                return NotFound("There is no appointments...");

            if (!date.HasValue)
                date = DateTime.Today;
            else
                date = date.Value.ToLocalTime().Date;

            const int startHour = 8;
            const int hourSpan = 9;

            var allPossibleTimes = Enumerable.Range(startHour, hourSpan)
                                             .Select(hour => date.Value.AddHours(hour))
                                             .SelectMany(d => Enumerable.Range(0, 2)
                                                                        .Select(min => d.AddMinutes(30 * min)))
                                             .ToList();

            var busyTimes = _context.agenda.Where(a => a.Agendamento.Date == date.Value.Date)
                                           .Select(a => a.Agendamento.ToLocalTime());

            var availableTimes = allPossibleTimes.Except(busyTimes).ToList();

            return availableTimes;
        }

        [HttpPost]
        public async Task<ActionResult<Agenda>> PostAgenda(CreateAgendaDto request)
        {
            var doador = await _context.doador.FindAsync(request.DoadorId);
            if (doador == null)
                return NotFound("Doador not found...");

            var newAgenda = new Agenda
            {
                DoadorId = request.DoadorId,
                Agendamento = request.Agendamento.ToLocalTime(),
                Doador = doador,
            };

            if (newAgenda.Agendamento.Minute % 15 != 0)
            {
                return BadRequest("Agendamento só aceita horas terminadas em 0, 15, 30 e 45 minutos...");
            }

            if (_context.agenda == null)
            {
                return BadRequest("Agenda can't be null");
            }
            _context.agenda.Add(newAgenda);
            await _context.SaveChangesAsync();

            return NoContent();
        }

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
    }
}
