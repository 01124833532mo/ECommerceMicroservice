using ECommerce.Core.DTO;
using FluentValidation;

namespace ECommerce.Core.Validators
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {


            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters long.");
            RuleFor(x => x.PersonName)
                .NotEmpty().WithMessage("Person name is required.")
                .MaximumLength(50).WithMessage("Person name cannot exceed 50 characters.");



        }
    }
}
