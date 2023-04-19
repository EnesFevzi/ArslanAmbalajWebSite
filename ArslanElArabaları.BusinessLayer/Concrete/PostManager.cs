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
    public class PostManager : IPostService
    {
        protected readonly IPostRepository _postRepository;

        public PostManager(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public List<Post> GetBlogsListWithWriter(int id)
        {
            throw new NotImplementedException();
        }

        public async Task TAddAsync(Post t)
        {
            await _postRepository.AddAsync(t);
        }

        public async Task TDeleteAsync(Post t)
        {
            await _postRepository.DeleteAsync(t);
        }

        public List<Post> TGetByFilter(Expression<Func<Post, bool>> filter)
        {
            return _postRepository.GetByFilter(filter);
        }

        public async Task<Post> TGetByIDAsync(int id)
        {
            return await _postRepository.GetByIDAsync(id);
        }

        public async Task<List<Post>> TGetListAsync()
        {
             return await _postRepository.GetListAsync();
        }

        public async Task TUpdateAsync(Post t)
        {
            await _postRepository.UpdateAsync(t);
        }
    }
}
