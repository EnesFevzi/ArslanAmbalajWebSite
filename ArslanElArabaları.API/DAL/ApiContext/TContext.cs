using ArslanElArabaları.API.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace ArslanElArabaları.API.DAL.ApiContext
{
    public class TContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=ArslanElArabalarıProjectAPI;integrated security=true");
            //optionsBuilder.UseSqlServer("server=DESKTOP-QMOGCM6; database=Test; integrated security=true;Encrypt=False;");
            //"Data Source=DESKTOP-SM0VBLO;Initial Catalog =IsSureciDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        }

        public DbSet<Post> Posts { get; set; }
    }
}
