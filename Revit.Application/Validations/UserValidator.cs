using Abp.Authorization.Users;
using FluentValidation;
using Revit.Application.Models.Users;
using Revit.Authorization.Users;
using Revit.Shared.Validations;

namespace AppFramework.Admin.Validations;

public class UserCreateOrUpdateValidator : AbstractValidator<UserCreateOrUpdateModel>
{
    public UserCreateOrUpdateValidator()
    {
        RuleFor(x => x.User.Name).IsRequired().MaxLength(AbpUserBase.MaxNameLength);
        RuleFor(x => x.User.Surname).IsRequired().MaxLength(AbpUserBase.MaxSurnameLength);
        RuleFor(x => x.User.UserName).IsRequired().MaxLength(AbpUserBase.MaxUserNameLength);
        RuleFor(x => x.User.EmailAddress).IsRequired().Email().MaxLength(AbpUserBase.MaxEmailAddressLength);
        RuleFor(x => x.User.PhoneNumber).MaxLength(UserConsts.MaxPhoneNumberLength);
        RuleFor(x => x.User.Password).MaxLength(AbpUserBase.MaxPlainPasswordLength);
    }
}