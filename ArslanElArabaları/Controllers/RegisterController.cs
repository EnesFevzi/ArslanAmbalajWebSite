using ArslanElArabaları.EntityLayer.Concrete;
using ArslanElArabaları.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ArslanElArabaları.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RegisterController : Controller
    {
        private readonly UserManager<AdminUser> _userManager;
        private readonly SignInManager<AdminUser> _signInManager;

        public RegisterController(UserManager<AdminUser> userManager, SignInManager<AdminUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }

        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel userRegisterViewModel)
        {

            AdminUser appUser = new AdminUser()
            {
                Name = userRegisterViewModel.Name,
                Surname = userRegisterViewModel.Surname,
                Email = userRegisterViewModel.Mail,
                UserName = userRegisterViewModel.UserName,
                ImageUrl = userRegisterViewModel.ImageUrl,
            };

            if (userRegisterViewModel.Password == userRegisterViewModel.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, userRegisterViewModel.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View(userRegisterViewModel);
        }
    }
}
