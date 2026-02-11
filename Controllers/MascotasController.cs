using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Data;
using Api.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MascotasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MascotasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/mascotas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mascota>>> GetMascotas()
        {
            return await _context.Mascotas.ToListAsync();
        }

        // GET: api/mascotas/*
        [HttpGet("{id}")]
        public async Task<ActionResult<Mascota>> GetMascota(int id)
        {
            var mascota = await _context.Mascotas.FindAsync(id);

            if (mascota == null)
            {
                return NotFound();
            }

            return mascota;
        }

        // POST: api/mascotas
        [HttpPost]
        public async Task<ActionResult<Mascota>> PostMascota(Mascota Mascota)
        {
            _context.Mascotas.Add(Mascota);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMascota", new { id = Mascota.Id }, Mascota);
        }

        // PUT: api/mascotas/*
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMascota(int id, Mascota mascota)
        {
            if (id != mascota.Id)
            {
                return BadRequest();
            }

            _context.Entry(mascota).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MascotaExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }


        // DELETE: api/mascotas/*
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMascota(int id)
        {
            var mascota = await _context.Mascotas.FindAsync(id);
            if (mascota == null)
            {
                return NotFound();
            }

            _context.Mascotas.Remove(mascota);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    
      private bool MascotaExists(int id)
        {
            return _context.Mascotas.Any(mascota => mascota.Id == id);
        }
    }
}

