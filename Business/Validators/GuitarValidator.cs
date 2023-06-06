using Business.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validators
{
    public class GuitarValidator : AbstractValidator<GuitarDTO>
    {
        public GuitarValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Incorrect value! Name can`t be null!")
                .NotEmpty().WithMessage("Incorrect value! Name can`t be empty!")
                .Length(5, 100).WithMessage("Incorrect value! Name have to be from 5 to 100 in length!");
            RuleFor(x => x.Type)
                .NotNull().WithMessage("Incorrect value! Type can`t be null!")
                .NotEmpty().WithMessage("Incorrect value! Type can`t be empty!")
                .MaximumLength(100).WithMessage("Incorrect value! Max length of Type is 100 symbols!");
            RuleFor(x => x.Color)
                .NotNull().WithMessage("Incorrect value! Color can`t be null!")
                .NotEmpty().WithMessage("Incorrect value! Color can`t be empty!")
                .MaximumLength(50).WithMessage("Incorrect value! Max length of Color is 50 symbols!"); ;
            RuleFor(x => x.Price)
                .NotNull().WithMessage("Incorrect value! Price can`t be null!")
                .NotEmpty().WithMessage("Incorrect value! Price can`t be empty!")
                .GreaterThanOrEqualTo(0).WithMessage("Incorrect value! Price can`t be less than 0!");
            RuleFor(x => x.Img)
                .NotNull().WithMessage("Incorrect value! Image can`t be null!")
                .NotEmpty().WithMessage("Incorrect value! Image can`t be empty!")
                .Must(LinkMustBeAUri).WithMessage("Incorrect value! Link '{PropertyValue}' must be a valid URI!");

        }

        private static bool LinkMustBeAUri(string link)
        {
            if (string.IsNullOrWhiteSpace(link)) return false;

            Uri outUri;
            return Uri.TryCreate(link, UriKind.Absolute, out outUri)
                   && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps);
        }
    }
}
