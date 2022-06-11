using Hemolink.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hemolink.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SangueController : Controller
    {
        private readonly _DbContext _context;
        public SangueController(_DbContext context)
        {
            _context = context;
        }   

        [HttpGet]
        public async Task<ActionResult<List<Sangue>>> Get()
        {
            return Ok(await _context.sangues.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Sangue>> Get(string id)
        {
            var sangue = await _context.sangues.FindAsync(id);
            if (sangue == null)
                return BadRequest("Blod not found... ");
            return Ok(sangue);
        }

    }
}
