using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WikiAPI.Models;

namespace WikiAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class PersonController : Controller
    {
        private readonly WikiSalesDbContext _context;
        public PersonController(WikiSalesDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Person> GetPerson()
        {
            return _context.Person.ToList();
        }

        [HttpGet("{id:int}")]
        public IActionResult GetPersonById(int id)
        {
            var per = this._context.Person.SingleOrDefault(ct => ct.perId == id);
            if (per != null)
            {
                return Ok(per);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{name}")]
        public IActionResult GetPersonByName(string name)
        {
            var info = this._context.Person.SingleOrDefault(ct => ct.perName == name);

            if (info == null)
            {
                return new NoContentResult();
            }
            else
            {
                return Ok(info);
            }
        }

        [HttpPost]
        public IActionResult AddPerson([FromBody] Person Person)
        {

            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            this._context.Person.Add(Person);
            this._context.SaveChanges();
            return Created($"Person/{Person.perId}", Person);
        }

        [HttpPut("{id}")]
        public IActionResult PutPerson(int id, [FromBody] Person Person)
        {

            var target = _context.Person.FirstOrDefault(ct => ct.perId == id);
            if (target == null)
            {
                return NotFound();
            }
            else
            {
                target.perId = Person.perId;
                target.perName = Person.perName;
                target.perLastname = Person.perLastname;
                target.perCtyId = Person.perCtyId;
                target.perPetId = Person.perPetId;
                _context.Person.Update(target);
                _context.SaveChanges();
                return new NoContentResult();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeletePerson(int id)
        {
            var target = _context.Person.FirstOrDefault(ct => ct.perId == id);
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.Person.Remove(target);
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}
