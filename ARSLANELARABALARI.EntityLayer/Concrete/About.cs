using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArslanElArabaları.EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string? AboutTitle { get; set; }
        public string? AboutDescription { get; set; }
        public string? AboutMail { get; set; }
        public string? AboutPhone { get; set; }
        public string? AboutAddress { get; set; }

    }
}
