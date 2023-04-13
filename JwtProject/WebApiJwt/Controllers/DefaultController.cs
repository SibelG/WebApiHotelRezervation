using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiJwt.Models;

namespace WebApiJwt.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet("[action")]
        public IActionResult token()
        {
            return Ok(new CreateToken().TokenCreate());
        }

        [HttpGet("[action")]
        public IActionResult AdminToken()
        {
            return Ok(new CreateToken().TokenCreateAdmin());
        }

        [Authorize]
        [HttpGet("[Action]")]
        public IActionResult Test2()
        {
            return Ok("hosgeldin");
        }
        [Authorize(Roles = "Admin,Visitor")]
        [HttpGet("[Action]")]
        public IActionResult Test3(){
            
            return Ok("hosgeldin");
         
        }


    }
}
