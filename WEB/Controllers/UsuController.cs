using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.Controllers
{
    public class UsuController : ControllerBase
    {

        private readonly DbContextSistema _context;
        public UsuController(DbContextSistema context)
        {
            _context = context;
        }
     

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usu>>> GetUsu()
        {
            return await _context.Usu.ToListAsync();
        }
[HttpGet("{idUsu}")]
        public async Task<ActionResult<Usu>> GetUsu(int id)
        {
            var Usu = await _context.Usu.FindAsync(id);


            if (Usu == null)
            {
                return NotFound();
            }
            return Usu;
        }
        [HttpPut("idUsu")]
        public async Task<IActionResult> PutUsu(int id, Usu Usu)
        {
            if (id != Usu.idUsu)
            {
                return BadRequest();
            }
            _context.Entry(Usu).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (UsuExists(id))
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
        public async Task<ActionResult<Usu>> PostCategoria(Usu Usu)
        {
            _context.Usu.Add(Usu);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetUsu", new { id = Usu.idUsu }, Usu);
        }
        [HttpDelete("idUsu")]
        public async Task<ActionResult<Usu>> DeleteUsu(int id)
        {
            var Usu = await _context.Usu.FindAsync(id);
            if (Usu == null)
            {
                return NotFound();
            }
            _context.Usu.Remove(Usu);
            await _context.SaveChangesAsync();
            return Usu;
        }

        private bool UsuExists(int id)
        {
            return _context.Usu.Any(z => z.idUsu == id);
        }
    }
}
