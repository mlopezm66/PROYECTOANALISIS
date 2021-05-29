using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraDController
    {
        private readonly DbContextSistema _context;
        public CompraDsController(DbContextSistema context)
        {
            _context = context;
        }
      
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompraD>>> GetCompraDs()
        {
            return await _context.CompraDs.ToListAsync();
        }

        [HttpGet("{idCompraD}")]
        public async Task<ActionResult<CompraD>> GetCompraD(int id)
        {
            var CompraD = await _context.CompraDs.FindAsync(id);


            if (CompraD == null)
            {
                return NotFound();
            }
            return CompraD;
        }
        [HttpPut("idCompraD")]
        public async Task<IActionResult> PutCompraD(int id, CompraD CompraD)
        {
            if (id != CompraD.idCompraD)
            {
                return BadRequest();
            }
            _context.Entry(CompraD).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (CompraDExists(id))
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
        public async Task<ActionResult<CompraD>> PostCategoria(CompraD CompraD)
        {
            _context.CompraDs.Add(CompraD);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetCompraD", new { id = CompraD.idCompraD }, CompraD);
        }
      
        [HttpDelete("idCompraD")]
        public async Task<ActionResult<CompraD>> DeleteCategoria(int id)
        {
            var CompraD = await _context.CompraDs.FindAsync(id);
            if (CompraD == null)
            {
                return NotFound();
            }
            _context.CompraDs.Remove(CompraD);
            await _context.SaveChangesAsync();
            return CompraD;
        }

private bool CompraDExists(int id)
        {
            return _context.CompraDs.Any(z => z.idCompraD == id);
        }
    }
}
