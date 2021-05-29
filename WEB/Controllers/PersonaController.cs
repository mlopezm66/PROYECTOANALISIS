using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : Controller
    {
        private readonly DbContextSistema _context;
        public PersonaController(DbContextSistema context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Persona>>> GetPersona()
        {
            return await _context.Persona.ToListAsync();
        }

        [HttpGet("{DPI}")]
        public async Task<ActionResult<Persona>> GetPersona(int id)
        {
            var Persona = await _context.Persona.FindAsync(id);


            if (Persona == null)
            {
                return NotFound();
            }
            return Persona;
        }
        [HttpPut("DPIa")]
        public async Task<IActionResult> PutPersona(int id, Persona Persona)
        {
            if (id != Persona.DPIa)
            {
                return BadRequest();
            }
            _context.Entry(Persona).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (PersonaExists(id))
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
        
        [HttpPost]
        public async Task<ActionResult<Persona>> PostPersona(Persona Persona)
        {
            _context.Persona.Add(Persona);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetPersona", new { id = Persona.DPIa }, Persona);
        }
        [HttpDelete("DPIa")]
        public async Task<ActionResult<Persona>> DeletePersona(int id)
        {
            var Persona = await _context.Persona.FindAsync(id);
            if (Persona == null)
            {
                return NotFound();
            }
            _context.Persona.Remove(Persona);
            await _context.SaveChangesAsync();
            return Persona;
        }


        private bool PersonaExists(int id)
        {
            return _context.Persona.Any(z => z.DPIa == id);
        }
    }
}