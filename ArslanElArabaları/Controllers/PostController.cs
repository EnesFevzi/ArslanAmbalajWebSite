using ArslanElArabaları.BusinessLayer.Abstract;
using ArslanElArabaları.BusinessLayer.Concrete;
using ArslanElArabaları.BusinessLayer.ValidationRules;
using ArslanElArabaları.DataAccessLayer.Concrete;
using ArslanElArabaları.EntityLayer.Concrete;
using ArslanElArabaları.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Configuration;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Hosting;

namespace ArslanElArabaları.Controllers
{
    [Authorize(Roles = "Admin")]

    public class PostController : Controller
    {
        protected readonly IPostService _postService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        protected readonly TContext _context;

        public PostController(IPostService postService, TContext context, IWebHostEnvironment webHostEnvironment)
        {
            _postService = postService;
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        [AllowAnonymous]
        public async Task<IActionResult> PostListByWriter()
        {
            var values = await _postService.TGetListAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult PostAdd()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> PostAdd(Post b)
        {
            PostValidator validationRules = new PostValidator();
            var results = validationRules.Validate(b);
            if (results.IsValid)
            {
                b.PostStatus = true;
                b.PostCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                await _postService.TAddAsync(b);
                return RedirectToAction("PostListByWriter", "Post");
                // Blog kaydetme işlemini gerçekleştirin  
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                // Doğrulama hatası olduğu için hata mesajlarını döndürün          
            }
            return View();

        }

        public async Task<IActionResult> DeletePost(int id)
        {
            var values = await _postService.TGetByIDAsync(id);
            await _postService.TDeleteAsync(values);
            return RedirectToAction("PostListByWriter", "Post");
        }
        [HttpGet]
        public async Task<IActionResult> EditPost(int id)
        {
            var values = await _postService.TGetByIDAsync(id);

            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> EditPost(Post b)
        {

            b.PostStatus = true;
            b.PostCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            await _postService.TUpdateAsync(b);
            return RedirectToAction("PostListByWriter", "Post");
            // Blog kaydetme işlemini gerçekleştirin  
        }


    }

}

