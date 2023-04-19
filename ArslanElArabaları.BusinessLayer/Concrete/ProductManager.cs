using ArslanElArabaları.BusinessLayer.Abstract;
using ArslanElArabaları.DataAccessLayer.Abstract;
using ArslanElArabaları.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArslanElArabaları.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        protected readonly IProductRepository _productrepository;

        public ProductManager(IProductRepository productrepository)
        {
            _productrepository = productrepository;
        }

        public async Task TAddAsync(Product t)
        {
            await _productrepository.AddAsync(t);
        }

        public async Task TDeleteAsync(Product t)
        {
            await _productrepository.UpdateAsync(t);
        }

        public List<Product> TGetByFilter(Expression<Func<Product, bool>> filter)
        {
            return _productrepository.GetByFilter(filter);
        }

        public async Task<Product> TGetByIDAsync(int id)
        {
            return await _productrepository.GetByIDAsync(id);
        }

        public async Task<List<Product>> TGetListAsync()
        {
            return await _productrepository.GetListAsync();
        }

        public async Task TUpdateAsync(Product t)
        {
            await _productrepository.UpdateAsync(t);
        }
    }
}
