using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly DbContextSistema _context;
        public RolesController(DbContextSistema context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rol>>> GetRoles()
        {
            return await _context.Roles.ToListAsync();
        }

        [HttpGet("{idRol}")]
        public async Task<ActionResult<Rol>> GetRol(int id)
        {
            var rol = await _context.Roles.FindAsync(id);


            if (rol == null)
            {
                return NotFound();
            }
            return rol;
        }
        [HttpPut("idRol")]
        public async Task<IActionResult> PutRol(int id, Rol rol)
        {
            if (id != rol.idRol)
            {
                return BadRequest();
            }
            _context.Entry(rol).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (RolExists(id))
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
        public async Task<ActionResult<Rol>> PostRol(Rol rol)
        {
            _context.Roles.Add(rol);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetRol", new { id = rol.idRol }, rol);
        }
        [HttpDelete("idRol")]
        public async Task<ActionResult<Rol>> DeleteRol(int id)
        {
            var rol = await _context.Roles.FindAsync(id);
            if (rol == null)
            {
                return NotFound();
            }
            _context.Roles.Remove(rol);
            await _context.SaveChangesAsync();
            return rol;
        }
        
        private bool RolExists(int id)
        {
            return _context.Roles.Any(z => z.idRol == id);
        }
    }
}