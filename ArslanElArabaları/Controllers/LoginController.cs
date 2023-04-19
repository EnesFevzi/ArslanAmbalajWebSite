using ArslanElArabaları.EntityLayer.Concrete;
using ArslanElArabaları.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ArslanElArabaları.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AdminUser> _signInManager;
        private readonly UserManager<AdminUser> _userManager;

        public LoginController(SignInManager<AdminUser> signInManager, UserManager<AdminUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, true, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "AdminDefault", new { area = "Admin" });
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre");
                }
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
