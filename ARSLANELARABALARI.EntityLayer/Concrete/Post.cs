using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArslanElArabaları.EntityLayer.Concrete
{
    public class Post
    {
        public int PostID { get; set; }
        public string? PostTitle { get; set; }
        public string? PostImage { get; set; }
        public DateTime PostCreateDate { get; set; }
        public bool? PostStatus { get; set; }

    }
}
