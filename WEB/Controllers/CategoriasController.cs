using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.Controllers
{
    public class CategoriasController
    {

        [Route("api/[controller]")]
        [ApiController]
        public class CategoriasController : ControllerBase
        {
            private readonly DbContextSistema _context;
            public CategoriasController(DbContextSistema context)
            {
                _context = context;
            }

            [HttpGet]
            public async Task<ActionResult<IEnumerable<Categoria>>> GetCategorias()
            {
                return await _context.Categorias.ToListAsync();
            }

            [HttpGet("{idcategoria}")]
            public async Task<ActionResult<Categoria>> GetCategoria(int id)
            {
                var categoria = await _context.Categorias.FindAsync(id);


                if (categoria == null)
                {
                    return NotFound();
                }
                return categoria;
            }
            [HttpPut("idcategoria")]
            public async Task<IActionResult> PutCategoria(int id, Categoria categoria)
            {
                if (id != categoria.idcategoria)
                {
                    return BadRequest();
                }
                _context.Entry(categoria).State = EntityState.Modified;
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (CategoriaExists(id))
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
            public async Task<ActionResult<Categoria>> PostCategoria(Categoria categoria)
            {
                _context.Categorias.Add(categoria);
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetCategoria", new { id = categoria.idcategoria }, categoria);
            }

            [HttpDelete("idCategoria")]
            public async Task<ActionResult<Categoria>> DeleteCategoria(int id)
            {
                var categoria = await _context.Categorias.FindAsync(id);
                if (categoria == null)
                {
                    return NotFound();
                }
                _context.Categorias.Remove(categoria);
                await _context.SaveChangesAsync();
                return categoria;
            }
            private bool CategoriaExists(int id)
            {
                return _context.Categorias.Any(z => z.idcategoria == id);
            }
        }
    }