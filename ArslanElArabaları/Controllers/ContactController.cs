using ArslanElArabaları.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ArslanElArabaları.Controllers
{
    public class ContactController : Controller
    {
        protected readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task<IActionResult> Index()
        {
            var values =await  _contactService.TGetListAsync();
            return View(values);
        }
        public async Task<IActionResult> DeleteContact(int id)
        {
            var values = await _contactService.TGetByIDAsync(id);
            await _contactService.TDeleteAsync(values);
            return RedirectToAction("Index","Contact");
        }

        public async Task<IActionResult> ContactDetails(int id)
        {
            var values =await _contactService.TGetByIDAsync(id);
            return View(values);
        }
    }
}
