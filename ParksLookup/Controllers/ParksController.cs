using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksLookup.Models;

namespace ParksLookup.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParksLookupContext _db;

    public ParksController(ParksLookupContext db)
    {
      _db = db;
    }

    // GET api/parks
    /// <summary>
    /// Gets all parks. Chain parameters on query to get park by type or name. Parameters include "type" "location" and "name." For example `api/Parks?type=state` gets all state parks, `api/Parks?type=national` gets all national parks. Other example queries by parameters include api/Parks?location=Utah` `api/Parks?name=Arches`
    /// </summary> 
    /// <param name="type"></param>
    /// <param name="name"></param>
    /// <param name="location"></param>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string type, string name, string location)
    {
      var query = _db.Parks.AsQueryable();

      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }         
      return await query.ToListAsync();
      
    }
    /// <summary>
    /// Adds a specific park.
    /// </summary> 
    /// <param name="park"></param>
    // POST api/parks
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetPark), new{ id = park.ParkId }, park);
    }

    // GET: api/Parks/2
    /// <summary>
    /// Returns a specific park.
    /// </summary> 
    /// <param name="id"></param>
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
        var park = await _db.Parks.FindAsync(id);

        if (park == null)
        {
            return NotFound();
        }

        return park;
    }

    // PUT: api/Parks/2
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    /// <summary>
    /// Edits a specific park.
    /// </summary> 
    /// <param name="id"></param>
    /// <param name="park"></param>
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Entry(park).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
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

     // DELETE: api/Parks/5
     /// <summary>
    /// Deletes a specific Park.
    /// </summary>
    /// <param name="id"></param>     
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      var park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }

  }
}