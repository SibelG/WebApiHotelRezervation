using FluentValidation;
using FluentValidation.AspNetCore;
using WebUI.Dtos.GuestDto;

namespace WebUI.ValidationRules.GuestValidationRules
{
    public class CreateGuestValidator:AbstractValidator<CreateGuestDto>
    {
       public CreateGuestValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Name is not empty");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("SurName is not empty");
            RuleFor(x => x.City).NotEmpty().WithMessage("City is not empty");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Please enter 3 characters data");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage(" Please enter 3 characters data");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Please enter 3 characters data");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Please enter 3 characters data");
            RuleFor(x => x.Surname).MaximumLength(30).WithMessage(" Please enter 3 characters data");
            RuleFor(x => x.City).MaximumLength(20).WithMessage("Please enter 3 characters data");



        }
    }
}
