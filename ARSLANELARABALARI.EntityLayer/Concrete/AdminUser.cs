using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ArslanElArabaları.EntityLayer.Concrete
{
    public class AdminUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? ImageUrl { get; set; }
        //public List<Post> Posts { get; set; }
        public List<Product> Products { get; set; }

    }
}
