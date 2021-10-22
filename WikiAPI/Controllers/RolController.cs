using System.Collections.Generic;
using System.Linq;
using WikiAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace WikiAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class RolController : Controller
    {
        private readonly WikiSalesDbContext _context;

        public RolController(WikiSalesDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Rol> GetRoles()
        {
            return _context.Rol.ToList();
        }

        [HttpGet("{id:int}")]
        public IActionResult GetRolById(int id)
        {
            var rol = this._context.Rol.SingleOrDefault(ct => ct.rolId == id);
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
        public IActionResult GetRolByName(string name)
        {
            var info = this._context.Rol.SingleOrDefault(ct => ct.rolNombre == name);

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
        public IActionResult AddRol([FromBody] Rol rol)
        {

            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            this._context.Rol.Add(rol);
            this._context.SaveChanges();
            return Created($"rol/{rol.rolId}", rol);
        }

        [HttpPut("{id}")]
        public IActionResult PutRol(int id, [FromBody] Rol rol)
        {

            var target = _context.Rol.FirstOrDefault(ct => ct.rolId == id);
            if (target == null)
            {
                return NotFound();
            }
            else
            {
                target.rolId = rol.rolId;
                target.rolNombre = rol.rolNombre;

                _context.Rol.Update(target);
                _context.SaveChanges();
                return new NoContentResult();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRol(int id)
        {
            var target = _context.Rol.FirstOrDefault(ct => ct.rolId== id);
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.Rol.Remove(target);
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}