using FluentValidation;

namespace AppFramework.Admin.Validations;

public class CreateEditionValidator : AbstractValidator<EditionCreateModel>
{
    public CreateEditionValidator()
    {
        RuleFor(x => x.DisplayName).IsRequired();
    }
}