using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ReferencesValidator:AbstractValidator<References>
    {
        public ReferencesValidator() 
        {
            RuleFor(x=>x.ReferencesImage).NotEmpty().WithMessage("Referans Resmi Boş Geçilemez");
            RuleFor(x=>x.ReferencesTitle).NotEmpty().WithMessage("Referans İsmi Boş Geçilemez");
            RuleFor(x=>x.ReferencesDescription).NotEmpty().WithMessage("Referans Açıklaması Boş Geçilemez");
        }
    }
}
