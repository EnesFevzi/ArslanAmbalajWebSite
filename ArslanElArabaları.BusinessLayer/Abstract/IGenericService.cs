using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArslanElArabaları.BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        Task TAddAsync(T t);
        Task TDeleteAsync(T t);
        Task TUpdateAsync(T t);
        Task<List<T>> TGetListAsync();
        Task<T> TGetByIDAsync(int id);
        List<T> TGetByFilter(Expression<Func<T, bool>> filter);
    }
}
