using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.Controllers
{
    public class VentaDController : Controller
    {
        private readonly DbContextSistema _context;
        public VentasDsController(DbContextSistema context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VentasD>>> GetVentasD()
        {
            return await _context.VentasDs.ToListAsync();
        }

        [HttpGet("{idVentasD}")]
        public async Task<ActionResult<VentasD>> GetVentasD(int id)
        {
            var VentasD = await _context.VentasDs.FindAsync(id);


            if (VentasD == null)
            {
                return NotFound();
            }
            return VentasD;
        }
        [HttpPut("idVentasD")]
        public async Task<IActionResult> PutVentasD(int id, VentasD VentasD)
        {
            if (id != VentasD.idVentasD)
            {
                return BadRequest();
            }
            _context.Entry(VentasD).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (VentasDExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }[HttpPost]
        public async Task<ActionResult<VentasD>> PostVentasD(VentasD VentasD)
        {
            _context.VentasDs.Add(VentasD);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetVentasD", new { id = VentasD.idVentasD }, VentasD);
        }
        [HttpDelete("idVentasD")]
        public async Task<ActionResult<VentasD>> DeleteVentasD(int id)
        {
            var VentasD = await _context.VentasDs.FindAsync(id);
            if (VentasD == null)
            {
                return NotFound();
            }
            _context.VentasDs.Remove(VentasD);
            await _context.SaveChangesAsync();
            return VentasD;
        }
        private bool VentasDExists(int id)
        {
            return _context.VentasDs.Any(z => z.idVentasD == id);
        }
    }
}
