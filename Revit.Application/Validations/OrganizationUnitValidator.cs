using Abp.Organizations;
using FluentValidation;

namespace AppFramework.Admin.Validations;

public class OrganizationUnitValidator : AbstractValidator<CreateOrganizationUnitModel>
{
    public OrganizationUnitValidator()
    {
        RuleFor(x => x.DisplayName).IsRequired().MaxLength(OrganizationUnit.MaxDisplayNameLength);
    }
}