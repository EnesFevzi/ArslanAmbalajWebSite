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
    public class ExperienceManager : IExperienceService
    {
        protected readonly IExperienceRepository _experienceRepository;

        public ExperienceManager(IExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }

        public async Task TAddAsync(Experience t)
        {
            await _experienceRepository.AddAsync(t);
        }

        public async Task TDeleteAsync(Experience t)
        {
            await _experienceRepository.DeleteAsync(t);
        }

        public List<Experience> TGetByFilter(Expression<Func<Experience, bool>> filter)
        {
            return _experienceRepository.GetByFilter(filter);
        }

        public async Task<Experience> TGetByIDAsync(int id)
        {
            return await _experienceRepository.GetByIDAsync(id);
        }

        public async Task<List<Experience>> TGetListAsync()
        {
            return await _experienceRepository.GetListAsync();
        }

        public async Task TUpdateAsync(Experience t)
        {
            await _experienceRepository.UpdateAsync(t);
        }
    }
}
