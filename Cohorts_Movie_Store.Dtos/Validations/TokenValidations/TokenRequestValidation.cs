using Cohorts_Movie_Store.Dtos.Token;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Dtos.Validations.TokenValidations
{
    public class TokenRequestValidation : AbstractValidator<TokenRequest>
    {
        public TokenRequestValidation()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email field cannot be empty.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password field cannot be empty.");
        }
    }
}
