using Abp.Authorization.Users;
using FluentValidation;
using Revit.Shared.Entity.Family;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revit.Families;
using Revit.Shared.Validations;

namespace Revit.Application.Validations
{
    public class CategoryValidator:AbstractValidator<CategoryForEditModel>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).IsRequired("Name is required.").MaxLength(AbpUserBase.MaxNameLength);
        }
    }
}
