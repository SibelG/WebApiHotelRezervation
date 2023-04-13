using EntityLayer.Concrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebUI.Dtos.RegisterDto;

namespace WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();  
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto newUser)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser()
            {
                Name = newUser.Name,
                Email = newUser.Email,
                Surname = newUser.Surname,
                UserName = newUser.UserName
            };
            var result = await _userManager.CreateAsync(appUser,newUser.Password);
            if(result.Succeeded) 
            {
                return RedirectToAction("Index","Login");   
            }
            return View();
        }
    }
}
