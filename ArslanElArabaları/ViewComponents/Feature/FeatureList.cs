using ArslanElArabaları.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ArslanElArabaları.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        protected readonly IAboutService _aboutService;

        public FeatureList(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task< IViewComponentResult> InvokeAsync()
        {
            var values = await _aboutService.TGetListAsync();
            return View(values);
        }
    }

}
