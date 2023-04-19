using ArslanElArabaları.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ArslanElArabaları.ViewComponents.Portfolio
{
    public class PortfolioList : ViewComponent
    {
        protected readonly IPostService _postService;

        public PortfolioList(IPostService postService)
        {
            _postService = postService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _postService.TGetListAsync();
            return View(values);
        }
    }
}
