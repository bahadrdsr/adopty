using FluentValidation;

namespace Application.Assets.Commands.CreateAsset
{
    public class CreateAssetCommandValidator : AbstractValidator<CreateAssetCommand>
    {
        public CreateAssetCommandValidator()
        {
            RuleFor(x => x.File).NotEmpty();
        }
    }
}