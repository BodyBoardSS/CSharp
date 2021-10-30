using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WikiAPI.Models;

namespace WikiAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class AddressController : Controller
    {
        private readonly WikiSalesDbContext _context;
        public AddressController(WikiSalesDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Address> GetAddress()
        {
            return _context.Address.ToList();
        }

        [HttpGet("{id:int}")]
        public IActionResult GetAddressById(int id)
        {
            var add = this._context.Address.SingleOrDefault(ct => ct.addId == id);
            if (add != null)
            {
                return Ok(add);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{address}")]
        public IActionResult GetAddressByName(string address)
        {
            var info = this._context.Address.SingleOrDefault(ct => ct.address == address);

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
        public IActionResult AddAddress([FromBody] Address Address)
        {

            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            this._context.Address.Add(Address);
            this._context.SaveChanges();
            return Created($"Address/{Address.addId}", Address);
        }

        [HttpPut("{id}")]
        public IActionResult PutAddress(int id, [FromBody] Address Address)
        {

            var target = _context.Address.FirstOrDefault(ct => ct.addId == id);
            if (target == null)
            {
                return NotFound();
            }
            else
            {
                target.addId = Address.addId;
                target.address = Address.address;
                target.person = Address.person;
                _context.Address.Update(target);
                _context.SaveChanges();
                return new NoContentResult();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAddress(int id)
        {
            var target = _context.Address.FirstOrDefault(ct => ct.addId == id);
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.Address.Remove(target);
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}
