using ArslanElArabaları.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ArslanElArabaları.ViewComponents.AdminNavbarProfile2
{
    public class AdminNavbarProfile2 : ViewComponent
    {
        private readonly UserManager<AdminUser> _userManager;
        private readonly SignInManager<AdminUser> _signInManager;

        public AdminNavbarProfile2(UserManager<AdminUser> userManager, SignInManager<AdminUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var writer = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Names = writer.Name + " " + writer.Surname;
            ViewBag.Values = writer.ImageUrl;
            var roles = await _userManager.GetRolesAsync(writer);
            ViewBag.Role = roles.FirstOrDefault();
            return View(writer);
        }
    
    }
}
