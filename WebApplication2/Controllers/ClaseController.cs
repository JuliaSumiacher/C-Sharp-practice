using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;
using WebApplication.Data;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClaseController : ControllerBase
    {
        private readonly ColegioContext _context;

        public ClaseController(ColegioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clase>>> GetClases()
        {
            return await _context.Clases.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Clase>> GetClase(int id)
        {
            var clase = await _context.Clases.FindAsync(id);
            if (clase == null) return NotFound();
            return clase;
        }

        [HttpPost]
        public async Task<ActionResult<Clase>> PostClase(Clase clase)
        {
            _context.Clases.Add(clase);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetClase), new { id = clase.Id }, clase);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutClase(int id, Clase clase)
        {
            if (id != clase.Id) return BadRequest();
            _context.Entry(clase).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClase(int id)
        {
            var clase = await _context.Clases.FindAsync(id);
            if (clase == null) return NotFound();
            _context.Clases.Remove(clase);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

