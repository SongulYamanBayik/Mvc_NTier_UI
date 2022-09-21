using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class CategoryValidator: AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Geçilemez!");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Kategori Adı en fazla 20 karekter olmalıdır.");
            RuleFor(x => x.CategoryName).MinimumLength(5).WithMessage("Kategori Adı en az 5 karekter olmalıdır.");
            
        }
    }
}
