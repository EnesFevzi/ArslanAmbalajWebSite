using ArslanElArabaları.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ArslanElArabaları.BusinessLayer.Abstract
{
    public interface IPostService:IGenericService<Post>
    {
        List<Post> GetBlogsListWithWriter(int id);
    }
}
