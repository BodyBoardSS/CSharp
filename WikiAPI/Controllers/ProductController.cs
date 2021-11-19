using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WikiAPI.Models;

namespace WikiAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class ProductController : Controller
    {
        private readonly WikiSalesDbContext _context;
        public ProductController(WikiSalesDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Product> GetProduct()
        {
            return _context.Product.ToList();
        }

        [HttpGet("{id:int}")]
        public IActionResult GetProductById(int id)
        {
            var prd = this._context.Product.SingleOrDefault(ct => ct.prdId == id);
            if (prd != null)
            {
                return Ok(prd);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{description}")]
        public IActionResult GetProductByName(string description)
        {
            var info = this._context.Product.SingleOrDefault(ct => ct.prdDescription == description);

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
        public IActionResult AddProduct([FromBody] Product produt)
        {

            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            this._context.Product.Add(produt);
            this._context.SaveChanges();
            return Created($"Product/{produt.prdId}", produt);
        }

        [HttpPut("{id}")]
        public IActionResult PutProduct(int id, [FromBody] Product Product)
        {

            var target = _context.Product.FirstOrDefault(ct => ct.prdId == id);
            if (target == null)
            {
                return NotFound();
            }
            else
            {
                target.prdId = id;
                target.prdDescription = Product.prdDescription;
                target.prdPrice = Product.prdPrice;
                target.prdCost = Product.prdCost;
                target.prdStock = Product.prdStock;
                target.prdPdtId = Product.prdPdtId;
                target.prdSupId = Product.prdSupId;
                target.prdEntryDate = Product.prdEntryDate;
                
                _context.Product.Update(target);
                _context.SaveChanges();
                return new NoContentResult();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var target = _context.Product.FirstOrDefault(ct => ct.prdId == id);
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.Product.Remove(target);
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}
