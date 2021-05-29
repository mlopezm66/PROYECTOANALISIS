using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sistemasdata;
using SistemasSociedad.compras;
using SistemasSociedad.bodega;

namespace WEB.Controllers
{
    public class ItemsController
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly DbContextSistema _context;
        public ItemsController(DbContextSistema context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Item>>> GetItems()
        {
            return await _context.Items.ToListAsync();
        }
        [HttpGet("{idItem}")]
        public async Task<ActionResult<Item>> GetItem(int id)
        {
            var Item = await _context.Items.FindAsync(id);


            if (Item == null)
            {
                return NotFound();
            }
            return Item;
        }
        [HttpPut("idItem")]
        public async Task<IActionResult> PutItem(int id, Item Item)
        {
            if (id != Item.idItem)
            {
                return BadRequest();
            }
            _context.Entry(Item).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (ItemExists(id))
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
        public async Task<ActionResult<Item>> PostCategoria(Item Item)
        {
            _context.Items.Add(Item);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetItem", new { id = Item.idItem }, Item);
        }

        [HttpDelete("idItem")]
        public async Task<ActionResult<Item>> DeleteItem(int id)
        {
            var Item = await _context.Items.FindAsync(id);
            if (Item == null)
            {
                return NotFound();
            }
            _context.Items.Remove(Item);
            await _context.SaveChangesAsync();
            return Item;
        }
        
        private bool ItemExists(int id)
        {
            return _context.Items.Any(z => z.idItem == id);
        }
    }
}