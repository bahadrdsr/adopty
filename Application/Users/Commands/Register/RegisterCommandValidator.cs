using FluentValidation;

namespace Application.Users.Commands.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator()
        {
            RuleFor(x=>x.Email).NotEmpty().MaximumLength(256).EmailAddress();
            RuleFor(x=>x.Password).NotEmpty().MinimumLength(6);
        }
    }
}