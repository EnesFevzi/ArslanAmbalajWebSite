using ArslanElArabaları.API.DAL.ApiContext;
using ArslanElArabaları.API.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArslanElArabaları.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {

        [HttpGet]
        public IActionResult PostList()
        {
            using var c = new TContext();
            return Ok(c.Posts.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult PostGet(int id)
        {
            using var c = new TContext();
            var value = c.Posts.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);
            }
        }
        [HttpPost]
        public IActionResult PostAdd(Post p)
        {
            using var c = new TContext();
            c.Add(p);
            c.SaveChanges();
            return Created("", p);
        }
        [HttpDelete]
        public IActionResult PostDelete(int id)
        {
            using var c = new TContext();
            var value = c.Posts.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(value);
                c.SaveChanges();
                return NoContent();
            }
        }
        [HttpPut]
        public IActionResult PostUpdate(Post p)
        {
            using var c = new TContext();
            var value = c.Find<Post>(p.PostID);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                value.PostTitle = p.PostTitle;
                c.Update(value);
                c.SaveChanges();
                return NoContent();
            }
        }
    }
}
