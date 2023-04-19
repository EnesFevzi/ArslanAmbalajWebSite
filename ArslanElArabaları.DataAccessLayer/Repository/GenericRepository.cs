using ArslanElArabaları.DataAccessLayer.Abstract;
using ArslanElArabaları.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArslanElArabaları.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly TContext _context;


        public GenericRepository(TContext context)
        {
            _context = context;
        }
        public async Task AddAsync(T t)
        {

            await _context.AddAsync(t);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T t)
        {
            _context.Remove(t);
            await _context.SaveChangesAsync();
        }

        public List<T> GetByFilter(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).ToList();
        }

        public async Task<T> GetByIDAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetListAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task UpdateAsync(T t)
        {
            _context.Update(t);
            await _context.SaveChangesAsync();
        }
    }
}
