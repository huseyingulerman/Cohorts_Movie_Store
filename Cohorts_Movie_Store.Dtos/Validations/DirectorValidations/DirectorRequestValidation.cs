using Cohorts_Movie_Store.Dtos.Director;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Dtos.Validations.DirectorValidations
{
    public class DirectorRequestValidation : AbstractValidator<DirectorRequest>
    {
        public DirectorRequestValidation()
        {
            RuleFor(x => x.Firstname).NotEmpty().WithMessage("Name field cannot be empty.").MaximumLength(75).WithMessage("The name is too long.").MinimumLength(3).WithMessage("The name is too short.");
            RuleFor(x => x.Lastname).NotEmpty().WithMessage("Lastname field cannot be empty.").MaximumLength(75).WithMessage("The lastname is too long.").MinimumLength(3).WithMessage("The lastname is too short.");
        }
    }
}
