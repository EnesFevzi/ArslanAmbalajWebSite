using ArslanElArabaları.DataAccessLayer.Concrete;
using ArslanElArabaları.EntityLayer.Concrete;
using ArslanElArabaları.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ArslanElArabaları.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<AdminUser> _userManager;
        private readonly TContext _context;

        public AdminController(UserManager<AdminUser> userManager, TContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public async Task<IActionResult> AdminEditProfile()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = values.Name;
            model.Surname = values.Surname;
            model.PictureURL = values.ImageUrl;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AdminEditProfile(UserEditViewModel userEditViewModel)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (userEditViewModel.Picture != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(userEditViewModel.Picture.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/UserImage/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await userEditViewModel.Picture.CopyToAsync(stream);
                user.ImageUrl = imagename;
            }

            user.Name = userEditViewModel.Name;
            user.Surname = userEditViewModel.Surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditViewModel.Password);

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("AdminEditProfile", "Admin");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(userEditViewModel);
        }
    }
}
