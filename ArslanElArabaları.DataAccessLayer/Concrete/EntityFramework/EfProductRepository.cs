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
    public class EfProductRepository : GenericRepository<Product>, IProductRepository
    {
        public EfProductRepository(TContext context) : base(context)
        {
        }
    }
}
