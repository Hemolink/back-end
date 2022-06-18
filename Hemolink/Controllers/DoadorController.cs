using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hemolink.Models;
using Hemolink.Data;
using Hemolink.Data.Dtos.Doador;

namespace Hemolink.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoadorController : Controller
    {
        private readonly _DbContext _context;

        public DoadorController(_DbContext context)
        {
            _context = context;
        }

        // GET: api/Doador
        [HttpGet]
        public async Task<ActionResult<List<Doador>>> Getdoador()
        {
          if (_context.doador == null)
          {
              return NotFound();
          }
            return Ok(await _context.doador.ToListAsync());
        }

        // GET: api/Doador/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Doador>> GetDoador(int id)
        {
          if (_context.doador == null)
          {
              return NotFound("Doador not found...");
          }
            var doador = await _context.doador.FindAsync(id);

            if (doador == null)
            {
                return NotFound("Doador not found...");
            }

            return doador;
        }

        // GET: api/Doador/e/sguedes46@gmail.com
        [HttpGet("e/{email}")]
        public async Task<ActionResult<LoginDto>> GetDoadorByEmail(string email)
        {
          if (_context.doador == null)
          {
              return NotFound("Doador not found...");
          }
            var doador = await _context.doador.FirstOrDefaultAsync(d => d.Email == email);

            if (doador == null)
            {
                return NotFound("Doador not found...");
            }
            LoginDto Doador = new LoginDto
            {
                Email = doador.Email,
                Senha = doador.Senha
            };



            return Doador;
        }

        // PUT: api/Doador/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult> PutDoador(int id, UpdateDoadorDto request)
        {
            var sangue = await _context.sangues.FindAsync(request.SangueId);
            if (sangue == null)
                return NotFound("Blood not found...");


            var doador = new Doador
            {
                IdDoador = request.IdDoador,
                Nome = request.Nome,
                Sobrenome = request.Sobrenome,
                DataNascimento = request.DataNascimento,
                Email = request.Email,
                Senha = request.Senha,
                Sangue = sangue,
                SangueId = request.SangueId,
                CPF = request.CPF,
                UltimaDoacao = request.UltimaDoacao,
                Sexo = request.Sexo,
                Peso = request.Peso
            };

            if (id != doador.IdDoador)
            {
                return BadRequest("Id is not the same on the JSON");
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
                    return NotFound("Doador not found...");
                }
                else
                {
                    throw;
                }
            }

            return Ok(doador);
        }

        // POST: api/Doador
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Doador>> PostDoador(CreateDoadorDto request)
        {
            var sangue = await _context.sangues.FindAsync(request.SangueId);
            if (sangue == null)
                return NotFound("Blood not found...");

            var newDoador = new Doador
            {
                Nome = request.Nome,
                Sobrenome = request.Sobrenome,
                DataNascimento = request.DataNascimento,
                Email = request.Email,
                Senha = request.Senha,
                Sangue = sangue,
                SangueId = request.SangueId,
                CPF = request.CPF,
                UltimaDoacao = request.UltimaDoacao,
                Sexo = request.Sexo,
                Peso = request.Peso
            };
            _context.doador.Add(newDoador);
            await _context.SaveChangesAsync();

            return Ok(newDoador);
        }

        // DELETE: api/Doador/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteDoador(int id)
        {
            if (_context.doador == null)
            {
                return NotFound("Doador not found...");
            }
            var doador = await _context.doador.FindAsync(id);
            if (doador == null)
            {
                return NotFound();
            }

            _context.doador.Remove(doador);
            await _context.SaveChangesAsync();

            return Ok("Doador deleted successfully...");
        }

        private bool DoadorExists(int id)
        {
            return (_context.doador?.Any(e => e.IdDoador == id)).GetValueOrDefault();
        }
    }
}
