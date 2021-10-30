using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WikiAPI.Models;

namespace WikiAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class PhoneController : Controller
    {
        private readonly WikiSalesDbContext _context;
        public PhoneController(WikiSalesDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Phone> GetPhone()
        {
            return _context.Phone.ToList();
        }

        [HttpGet("{id:int}")]
        public IActionResult GetPhoneById(int id)
        {
            var pho = this._context.Phone.SingleOrDefault(ct => ct.phoId == id);
            if (pho != null)
            {
                return Ok(pho);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{phone}")]
        public IActionResult GetPhoneByName(string phone)
        {
            var info = this._context.Phone.SingleOrDefault(ct => ct.phoCellPhone == phone);

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
        public IActionResult AddPhone([FromBody] Phone Phone)
        {

            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            this._context.Phone.Add(Phone);
            this._context.SaveChanges();
            return Created($"Phone/{Phone.phoId}", Phone);
        }

        [HttpPut("{id}")]
        public IActionResult PutPhone(int id, [FromBody] Phone Phone)
        {

            var target = _context.Phone.FirstOrDefault(ct => ct.phoId == id);
            if (target == null)
            {
                return NotFound();
            }
            else
            {
                target.phoId = Phone.phoId;
                target.phoCellPhone = Phone.phoCellPhone;
                target.person = Phone.person;
                _context.Phone.Update(target);
                _context.SaveChanges();
                return new NoContentResult();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeletePhone(int id)
        {
            var target = _context.Phone.FirstOrDefault(ct => ct.phoId == id);
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.Phone.Remove(target);
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}
