using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ArslanElArabaları.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult AdminNavbarPartial()
        {

            return PartialView();
        }

        public PartialViewResult AdminFooterPartial()
        {
            return PartialView();
        }
    }
}
