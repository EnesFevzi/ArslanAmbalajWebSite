using ArslanElArabaları.BusinessLayer.Abstract;
using ArslanElArabaları.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ArslanElArabaları.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        protected IContactService _contactService;

        public DefaultController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderAndNavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult Feature()
        {
            return PartialView();
        }
        public PartialViewResult AboutPartial()
        {
            return PartialView();
        }
        public PartialViewResult Contactİnformation()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task< PartialViewResult> SendMessage(Contact p)
        {

            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = true;
            await _contactService.TAddAsync(p);
            return PartialView();
        }
    }
}
