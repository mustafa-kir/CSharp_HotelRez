using FluentValidation;
using OtelRezarvasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Business.ValidationRules.FluentValidation
{
    public class LoginValidator: AbstractValidator<Login>
    {
      public LoginValidator()
        {
            RuleFor(p => p.UserName).NotEmpty();
            RuleFor(p => p.UserPassword).NotEmpty();
            RuleFor(p => p.Assignment).NotEmpty();

        }
    }
}
