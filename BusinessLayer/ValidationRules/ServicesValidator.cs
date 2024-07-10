using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ServicesValidator : AbstractValidator<Services>
    {
        public ServicesValidator() 
        {
            RuleFor(x => x.ServicesImage).NotEmpty().WithMessage("Hizmet Resmi Boş Geçilemez");
            RuleFor(x => x.ServicesName).NotEmpty().WithMessage("Hizmet İsmi Boş Geçilemez");
            RuleFor(x => x.ServicesDescription).NotEmpty().WithMessage("Hizmet Açıklaması Boş Geçilemez");
        }
    }
}
