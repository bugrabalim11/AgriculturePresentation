using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x=>x.Description1).NotEmpty().WithMessage("Adres açıklaması 1 boş geçilemez!");
            RuleFor(x=>x.Description2).NotEmpty().WithMessage("Adres açıklaması 2 boş geçilemez!");
            RuleFor(x=>x.Description3).NotEmpty().WithMessage("Adres açıklaması 3 boş geçilemez!");
            RuleFor(x=>x.Description4).NotEmpty().WithMessage("Adres açıklaması 4 boş geçilemez!");
            RuleFor(x=>x.MapInfo).NotEmpty().WithMessage("Harita bilgisi boş geçilemez!");
            RuleFor(x=>x.Description1).MaximumLength(25).WithMessage("Adres açıklaması en fazla 25 karakter olabilir!");
            RuleFor(x=>x.Description2).MaximumLength(25).WithMessage("Adres açıklaması en fazla 25 karakter olabilir!");
            RuleFor(x=>x.Description3).MaximumLength(25).WithMessage("Adres açıklaması en fazla 25 karakter olabilir!");
            RuleFor(x=>x.Description4).MaximumLength(25).WithMessage("Adres açıklaması en fazla 25 karakter olabilir!");
        }
    }
}
