using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using XJTResourcesCore.Models;
using Microsoft.AspNetCore.Authorization;

namespace XJTResourcesCore.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _usermanager;

        public UserController(UserManager<ApplicationUser> usermanager)
        {
            _usermanager = usermanager;
        }

        [Authorize("Bearer")]        
        [HttpGet(Name = "userinfo")]
        public async Task<IActionResult> GetUserInfo()
        {          

            var user = await _usermanager.FindByNameAsync(HttpContext.User.Identity.Name);
            if (user == null)
                return Ok("no user / not logged in");
            return Ok(user);
        }
    }
}