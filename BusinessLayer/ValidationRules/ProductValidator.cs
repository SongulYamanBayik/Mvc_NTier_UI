using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class ProductValidator: AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("ürün Adı Boş Geçilemez!");
            RuleFor(x => x.ProductStock).NotEmpty().WithMessage("ürün Stoğu Boş Geçilemez!");
            RuleFor(x => x.ProductPrice).NotEmpty().WithMessage("ürün Fiyatı Boş Geçilemez!");

        }
    }
}
