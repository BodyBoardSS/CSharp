using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WikiAPI.Models;

namespace WikiAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class DocumentTypeController : Controller
    {
        private readonly WikiSalesDbContext _context;
        public DocumentTypeController(WikiSalesDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<DocumentType> GetDocumentType()
        {
            return _context.DocumentType.ToList();
        }

        [HttpGet("{id:int}")]
        public IActionResult GetDocumentTypeById(int id)
        {
            var dct = this._context.DocumentType.SingleOrDefault(ct => ct.dctId == id);
            if (dct != null)
            {
                return Ok(dct);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{name}")]
        public IActionResult GetDocumentTypeByName(string description)
        {
            var info = this._context.DocumentType.SingleOrDefault(ct => ct.dctDescription == description);

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
        public IActionResult AddDocumentType([FromBody] DocumentType DocumentType)
        {

            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            this._context.DocumentType.Add(DocumentType);
            this._context.SaveChanges();
            return Created($"DocumentType/{DocumentType.dctId}", DocumentType);
        }

        [HttpPut("{id}")]
        public IActionResult PutDocumentType(int id, [FromBody] DocumentType DocumentType)
        {

            var target = _context.DocumentType.FirstOrDefault(ct => ct.dctId == id);
            if (target == null)
            {
                return NotFound();
            }
            else
            {
                target.dctId = DocumentType.dctId;
                target.dctDescription = DocumentType.dctDescription;

                _context.DocumentType.Update(target);
                _context.SaveChanges();
                return new NoContentResult();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDocumentType(int id)
        {
            var target = _context.DocumentType.FirstOrDefault(ct => ct.dctId == id);
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.DocumentType.Remove(target);
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}
