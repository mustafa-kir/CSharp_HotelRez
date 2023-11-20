using FluentValidation;
using OtelRezarvasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Business.ValidationRules.FluentValidation
{
    public class BossValidatorr : AbstractValidator<Boss>
    {
        public BossValidatorr()
        {
            RuleFor(p => p.BossName).NotEmpty();
            RuleFor(p => p.BossPassword).NotEmpty();

        }
    }
}
