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
    public class EfContactRepository : GenericRepository<Contact>, IContactRepository
    {
        public EfContactRepository(TContext context) : base(context)
        {
        }
    }
}
