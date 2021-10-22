using System.Collections.Generic;
using System.Linq;
using WikiAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace WikiAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class PersonTypeController : Controller
    {
        private readonly WikiSalesDbContext _context;

        public PersonTypeController(WikiSalesDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<PersonType> GetPersonTypes()
        {
            return _context.PersonType.ToList();
        }

        [HttpGet("{id:int}")]
        public IActionResult GetPersonTypeById(int id)
        {
            var rol = this._context.PersonType.SingleOrDefault(ct => ct.petId == id);
            if (rol != null)
            {
                return Ok(rol);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{name}")]
        public IActionResult GetPersonTypeByName(string name)
        {
            var info = this._context.PersonType.SingleOrDefault(ct => ct.petDescription == name);

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
        public IActionResult AddPersonType([FromBody] PersonType pet)
        {

            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            this._context.PersonType.Add(pet);
            this._context.SaveChanges();
            return Created($"personType/{pet.petId}", pet);
        }

        [HttpPut("{id}")]
        public IActionResult PutPersonType(int id, [FromBody] PersonType pet)
        {

            var target = _context.PersonType.FirstOrDefault(ct => ct.petId == id);
            if (target == null)
            {
                return NotFound();
            }
            else
            {
                target.petId = pet.petId;
                target.petDescription = pet.petDescription;

                _context.PersonType.Update(target);
                _context.SaveChanges();
                return new NoContentResult();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeletePersonType(int id)
        {
            var target = _context.PersonType.FirstOrDefault(ct => ct.petId== id);
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.PersonType.Remove(target);
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}