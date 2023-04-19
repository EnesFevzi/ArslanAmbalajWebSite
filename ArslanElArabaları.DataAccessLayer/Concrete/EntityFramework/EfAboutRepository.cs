using ArslanElArabaları.DataAccessLayer.Abstract;
using ArslanElArabaları.DataAccessLayer.Repository;
using ArslanElArabaları.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArslanElArabaları.DataAccessLayer.Concrete.EntityFramework
{
    public class EfAboutRepository : GenericRepository<About>, IAboutRepository
    {
        public EfAboutRepository(TContext context) : base(context)
        {
        }
    }
}
