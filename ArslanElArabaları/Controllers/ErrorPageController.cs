using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ArslanElArabaları.Controllers
{
    [AllowAnonymous]
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error404()
        {
            return View();
        }
    }
}
