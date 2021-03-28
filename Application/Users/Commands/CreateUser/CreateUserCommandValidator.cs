using FluentValidation;

namespace Application.Users.Commands.CreateUser
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(x=>x.Email).NotEmpty().EmailAddress().MaximumLength(128);
            RuleFor(x=>x.Password).NotEmpty();
        }
    }
}