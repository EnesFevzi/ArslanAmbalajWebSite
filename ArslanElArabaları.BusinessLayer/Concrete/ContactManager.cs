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
    public class ContactManager : IContactService
    {
        protected readonly IContactRepository _contactRepository;

        public ContactManager(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task TAddAsync(Contact t)
        {
           await _contactRepository.AddAsync(t);
        }

        public async Task TDeleteAsync(Contact t)
        {
            await _contactRepository.DeleteAsync(t);
        }

        public  List<Contact> TGetByFilter(Expression<Func<Contact, bool>> filter)
        {
            return _contactRepository.GetByFilter(filter);
        }

        public async Task<Contact> TGetByIDAsync(int id)
        {
            return await _contactRepository.GetByIDAsync(id);
        }

        public async Task<List<Contact>> TGetListAsync()
        {
            return await _contactRepository.GetListAsync();
        }

        public async Task TUpdateAsync(Contact t)
        {
            await _contactRepository.UpdateAsync(t);
        }
    }
}
