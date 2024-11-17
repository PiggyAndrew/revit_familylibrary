using AppFramework.Admin.Validations;
using FluentValidation;
using Prism.Ioc;
using Revit.Application.Models.Users;
using Revit.Families;

namespace Revit.Application.Validations
{
    public static class ValidatorExtensions
    { 
        public static void AddValidators(this IContainerRegistry services)
        { 
            services.Register<IValidator<UserCreateOrUpdateModel>, UserCreateOrUpdateValidator>();
            services.Register<IValidator<CategoryForEditModel>, CategoryValidator>();
        }
    }
}
