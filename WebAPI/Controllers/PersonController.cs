using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PersonContext _context;

        public PersonController(PersonContext context)
        {
            _context = context;
        }

        // GET: api/Person
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Person>>> GetPersons()
        //{
        //    return await _context.Persons.ToListAsync();
        //}

        // GET: api/Person/
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<Person>> GetPerson()
        {

            if (HttpContext.User.HasClaim(c => c.Type == "Id"))
            {
                var personId = HttpContext.User.FindFirst("Id").Value;

                var person = await _context.Persons.FindAsync(Int32.Parse(personId));

                if (person == null)
                {
                    return NotFound();
                }
                return person;
            }
            else
            {
                return null;
            }   
        }

        // PUT: api/Person/
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPut]
        public async Task<IActionResult> PutPerson(Person person)
        {

            if (HttpContext.User.HasClaim(c => c.Type == "Id"))
            {
                var personId = HttpContext.User.FindFirst("Id").Value;

                _context.Entry(person).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(Int32.Parse(personId)))
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
            else
            {
                return BadRequest();
            }                
        }

        // POST: api/Person
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Person>> PostPerson(Person person)
        {
            _context.Persons.Add(person);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPerson), new { id = person.PersonID }, person);
        }

        // DELETE: api/Person/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson(int id)
        {
            var person = await _context.Persons.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }

            _context.Persons.Remove(person);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonExists(int id)
        {
            return _context.Persons.Any(e => e.PersonID == id);
        }
    }
}
