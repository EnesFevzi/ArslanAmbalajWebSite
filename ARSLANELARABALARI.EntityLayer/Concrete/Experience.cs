using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArslanElArabaları.EntityLayer.Concrete
{
    public class Experience
    {
        [Key]
        public int ExprienceID { get; set; }
        public string Name { get; set; }
        public string? CreateDate { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }

        //Navigation Prop
        public int WriterID { get; set; }
        public AdminUser Writer { get; set; }
    }
}
