using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Takım arkadaşı ismi boş geçilemez.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Takım arkadaşı görevi boş geçilemez.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görel yolu boş geçilemez.");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha az veri girişi yapın.");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Lütfen 5 karakterden daha fazla veri girişi yapın.");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha az veri girişi yapın.");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen 3 karakterden daha fazla veri girişi yapın.");
        }
    }
}
