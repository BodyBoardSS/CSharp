using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WikiAPI.Models;

namespace WikiAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class LoginController : Controller
    {

        private readonly WikiSalesDbContext _context;

        public LoginController(WikiSalesDbContext context)
        {
            _context = context;
        }

        
        [HttpPost]
        public IActionResult login([FromBody] User user)
        {
            var info = this._context.User.SingleOrDefault(ct => ct.useEmail == user.useEmail && ct.usePassword == user.usePassword);

            if (info == null)
            {
                return new NoContentResult();
            }
            else
            {
                return Ok(info);
            }
        }
       
    }
}
