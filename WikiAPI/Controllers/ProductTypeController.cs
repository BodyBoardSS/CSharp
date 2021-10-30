using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WikiAPI.Models;

namespace WikiAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class ProductTypeController : Controller
    {
        private readonly WikiSalesDbContext _context;
        public ProductTypeController(WikiSalesDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<ProductType> GetProductType()
        {
            return _context.ProductType.ToList();
        }

        [HttpGet("{id:int}")]
        public IActionResult GetProductTypeById(int id)
        {
            var pdt = this._context.ProductType.SingleOrDefault(ct => ct.pdtId == id);
            if (pdt != null)
            {
                return Ok(pdt);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{name}")]
        public IActionResult GetProductTypeByName(string description)
        {
            var info = this._context.ProductType.SingleOrDefault(ct => ct.pdtDescription == description);

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
        public IActionResult AddProductType([FromBody] ProductType ProductType)
        {

            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            this._context.ProductType.Add(ProductType);
            this._context.SaveChanges();
            return Created($"ProductType/{ProductType.pdtId}", ProductType);
        }

        [HttpPut("{id}")]
        public IActionResult PutProductType(int id, [FromBody] ProductType ProductType)
        {

            var target = _context.ProductType.FirstOrDefault(ct => ct.pdtId == id);
            if (target == null)
            {
                return NotFound();
            }
            else
            {
                target.pdtId = ProductType.pdtId;
                target.pdtDescription = ProductType.pdtDescription;

                _context.ProductType.Update(target);
                _context.SaveChanges();
                return new NoContentResult();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProductType(int id)
        {
            var target = _context.ProductType.FirstOrDefault(ct => ct.pdtId == id);
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.ProductType.Remove(target);
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}
