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
    public class AboutManager : IAboutService
    {
        private readonly IAboutRepository _aboutRepository;

        public AboutManager(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public async Task TAddAsync(About t)
        {
            await _aboutRepository.AddAsync(t);
        }

        public async Task TDeleteAsync(About t)
        {
            await _aboutRepository.DeleteAsync(t);
        }

        public  List<About> TGetByFilter(Expression<Func<About, bool>> filter)
        {
            return _aboutRepository.GetByFilter(filter);
        }

        public async Task<About> TGetByIDAsync(int id)
        {
            return await _aboutRepository.GetByIDAsync(id); 
        }

        public async Task<List<About>> TGetListAsync()
        {
            return await _aboutRepository.GetListAsync();
        }

        public async Task TUpdateAsync(About t)
        {
            await _aboutRepository.UpdateAsync(t);
        }
    }
}
