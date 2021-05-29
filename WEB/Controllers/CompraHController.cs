using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.Controllers
{
    public class CompraHController
    {
        private readonly DbContextSistema _context;
        public VentasController(DbContextSistema context)
        {
            _context = context;
        }
       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Venta>>> GetVentas()
        {
            return await _context.Ventas.ToListAsync();
        }
[HttpGet("{IDVenta}")]
        public async Task<ActionResult<Venta>> GetVenta(int id)
        {
            var Venta = await _context.Ventas.FindAsync(id);


            if (Venta == null)
            {
                return NotFound();
            }
            return Venta;
        }
        [HttpPut("IDVenta")]
        public async Task<IActionResult> PutVenta(int id, Venta Venta)
        {
            if (id != Venta.IDVenta)
            {
                return BadRequest();
            }
            _context.Entry(Venta).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (VentaExists(id))
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
        public async Task<ActionResult<Venta>> PostVenta(Venta Venta)
        {
            _context.Ventas.Add(Venta);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetVenta", new { id = Venta.IDVenta }, Venta);
        }

        [HttpDelete("IDVenta")]
        public async Task<ActionResult<Venta>> DeleteVenta(int id)
        {
            var Venta = await _context.Ventas.FindAsync(id);
            if (Venta == null)
            {
                return NotFound();
            }
            _context.Ventas.Remove(Venta);
            await _context.SaveChangesAsync();
            return Venta;
        }


        private bool VentaExists(int id)
        {
            return _context.Ventas.Any(z => z.IDVenta == id);
        }
    }
}
