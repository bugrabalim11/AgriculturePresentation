using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün ismi boş geçilemez.");
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage("Lütfen 100 karakterden daha az veri girişi yapın.");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("Lütfen 2 karakterden daha fazla veri girişi yapın.");
            RuleFor(x => x.Value).GreaterThanOrEqualTo(0).WithMessage("Ürün fiyatı 0' dan büyük olmalıdır.");
        }
    }
}
