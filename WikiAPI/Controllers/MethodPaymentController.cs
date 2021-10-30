using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WikiAPI.Models;

namespace WikiAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class MethodPaymentController : Controller
    {
        private readonly WikiSalesDbContext _context;
        public MethodPaymentController(WikiSalesDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<MethodPayment> GetMethodPayment()
        {
            return _context.MethodPayment.ToList();
        }

        [HttpGet("{id:int}")]
        public IActionResult GetMethodPaymentById(int id)
        {
            var mtp = this._context.MethodPayment.SingleOrDefault(ct => ct.mtpId == id);
            if (mtp != null)
            {
                return Ok(mtp);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{name}")]
        public IActionResult GetMethodPaymentByName(string description)
        {
            var info = this._context.MethodPayment.SingleOrDefault(ct => ct.mtpDescription == description);

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
        public IActionResult AddMethodPayment([FromBody] MethodPayment MethodPayment)
        {

            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            this._context.MethodPayment.Add(MethodPayment);
            this._context.SaveChanges();
            return Created($"MethodPayment/{MethodPayment.mtpId}", MethodPayment);
        }

        [HttpPut("{id}")]
        public IActionResult PutMethodPayment(int id, [FromBody] MethodPayment MethodPayment)
        {

            var target = _context.MethodPayment.FirstOrDefault(ct => ct.mtpId == id);
            if (target == null)
            {
                return NotFound();
            }
            else
            {
                target.mtpId = MethodPayment.mtpId;
                target.mtpDescription = MethodPayment.mtpDescription;

                _context.MethodPayment.Update(target);
                _context.SaveChanges();
                return new NoContentResult();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMethodPayment(int id)
        {
            var target = _context.MethodPayment.FirstOrDefault(ct => ct.mtpId == id);
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.MethodPayment.Remove(target);
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}
