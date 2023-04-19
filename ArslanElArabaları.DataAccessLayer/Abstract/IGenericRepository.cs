using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArslanElArabaları.DataAccessLayer.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T t);
        Task DeleteAsync(T t);
        Task UpdateAsync(T t);
        Task<List<T>> GetListAsync();
        Task<T> GetByIDAsync(int id);
        List<T> GetByFilter(Expression<Func<T, bool>> filter);
    }
}
