using ArslanElArabaları.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ArslanElArabaları.DataAccessLayer.Concrete
{
    public class TContext : IdentityDbContext<AdminUser, AdminRole, int>
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=ArslanElArabalarıProjectDB;integrated security=true");
        //    //optionsBuilder.UseSqlServer("server=DESKTOP-QMOGCM6; database=Test; integrated security=true;Encrypt=False;");
        //    //"Data Source=DESKTOP-SM0VBLO;Initial Catalog =IsSureciDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= 77.245.159.27\\MSSQLSERVER2019;database=seyyarel_;user=enes1;password=1c2C3C4C5C*");
            //optionsBuilder.UseSqlServer("server=DESKTOP-QMOGCM6; database=Test; integrated security=true;Encrypt=False;");
            //"Data Source=DESKTOP-SM0VBLO;Initial Catalog =IsSureciDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=DESKTOP-4JQAL1L\\ENESSQLSERVER;database=ArslanElArabalarıProjectDB;integrated security=true");
        //    //optionsBuilder.UseSqlServer("server=DESKTOP-QMOGCM6; database=Test; integrated security=true;Encrypt=False;");
        //    //"Data Source=DESKTOP-SM0VBLO;Initial Catalog =IsSureciDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        //}
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
