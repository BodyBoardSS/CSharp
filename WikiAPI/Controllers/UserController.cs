using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WikiAPI.Models;

namespace WikiAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class UserController : Controller
    {
        private readonly WikiSalesDbContext _context;
        public UserController(WikiSalesDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<User> GetUser()
        {
            return _context.User.ToList();
        }

        [HttpGet("{id:int}")]
        public IActionResult GetUserById(int id)
        {
            var use = this._context.User.SingleOrDefault(ct => ct.useId == id);
            if (use != null)
            {
                return Ok(use);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{email}")]
        public IActionResult GetUserByName(string email)
        {
            var info = this._context.User.SingleOrDefault(ct => ct.useEmail == email);

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
        public IActionResult AddUser([FromBody] User User)
        {

            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            this._context.User.Add(User);
            this._context.SaveChanges();
            return Created($"User/{User.useId}", User);
        }

        [HttpPut("{id}")]
        public IActionResult PutUser(int id, [FromBody] User User)
        {

            var target = _context.User.FirstOrDefault(ct => ct.useId == id);
            if (target == null)
            {
                return NotFound();
            }
            else
            {
                target.useId = User.useId;
                target.useEmail = User.useEmail;
                target.useUsuario = User.useUsuario;
                target.usePassword = User.usePassword;

                _context.User.Update(target);
                _context.SaveChanges();
                return new NoContentResult();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var target = _context.User.FirstOrDefault(ct => ct.useId == id);
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.User.Remove(target);
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}
