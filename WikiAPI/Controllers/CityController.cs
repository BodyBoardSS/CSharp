using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WikiAPI.Models;

namespace WikiAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class CityController : Controller
    {
        private readonly WikiSalesDbContext _context;

        public CityController(WikiSalesDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<City> GetCity()
        {
            return _context.City.ToList();
        }

        [HttpGet("{id:int}")]
        public IActionResult GetCityById(int id)
        {
            var rol = this._context.City.SingleOrDefault(ct => ct.ctyId == id);
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
        public IActionResult GetCityByName(string name)
        {
            var info = this._context.City.SingleOrDefault(ct => ct.ctyName == name);

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
        public IActionResult AddCity([FromBody] City city)
        {

            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            this._context.City.Add(city);
            this._context.SaveChanges();
            return Created($"city/{city.ctyId}", city);
        }

        [HttpPut("{id}")]
        public IActionResult PutCity(int id, [FromBody] City city)
        {

            var target = _context.City.FirstOrDefault(ct => ct.ctyId == id);
            if (target == null)
            {
                return NotFound();
            }
            else
            {
                target.ctyId = city.ctyId;
                target.ctyName = city.ctyName;

                _context.City.Update(target);
                _context.SaveChanges();
                return new NoContentResult();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCity(int id)
        {
            var target = _context.City.FirstOrDefault(ct => ct.ctyId == id);
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.City.Remove(target);
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}
