using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DeSejeBanditter.DAL.Models;
using DeSejeBanditter.DAL.Interfaces;

namespace DeSejeBanditter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SamuraisController : ControllerBase
    {
        private readonly ISamurai _context;

        public SamuraisController(ISamurai context)
        {
            _context = context;
        }

        // GET: api/Samurais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Samurai>>> GetSamurai()
        {
            _context.GetSamuraisAndHouse();
            return Ok();// await _context.Samurai.ToListAsync();
        }

        // GET: api/Samurais/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Samurai>> GetSamurai(int id)
        //{
        //    var samurai = await _context.Samurai.FindAsync(id);

        //    if (samurai == null)
        //    {
        //        return NotFound();
        //    }

        //    return samurai;
        //}

        //// PUT: api/Samurais/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutSamurai(int id, Samurai samurai)
        //{
        //    if (id != samurai.SamuraiId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(samurai).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SamuraiExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Samurais
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Samurai>> PostSamurai(Samurai samurai)
        //{
        //    _context.Samurai.Add(samurai);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetSamurai", new { id = samurai.SamuraiId }, samurai);
        //}

        //// DELETE: api/Samurais/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteSamurai(int id)
        //{
        //    var samurai = await _context.Samurai.FindAsync(id);
        //    if (samurai == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Samurai.Remove(samurai);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool SamuraiExists(int id)
        //{
        //    return _context.Samurai.Any(e => e.SamuraiId == id);
        //}
    }
}
