using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.DTOs;

namespace Business.Validators
{
    public class UserValidator : AbstractValidator<UserDTO>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email)
                .NotNull().WithMessage("Incorrect value! Email can`t be null!")
                .NotEmpty().WithMessage("Incorrect value! Email can`t be empty!");
        }
    }
}
