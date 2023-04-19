using ArslanElArabaları.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArslanElArabaları.BusinessLayer.ValidationRules
{
    public class PostValidator : AbstractValidator<Post>
    {
        public PostValidator()
        {
            RuleFor(x => x.PostTitle).NotEmpty().WithMessage("Post başlığı boş geçilemez");
            RuleFor(x => x.PostImage).NotEmpty().WithMessage("Lütfen (/Posts/resim.jpg) methodunu uygulayınız.");
           
        }
    }
        
}
