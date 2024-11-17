using Newtonsoft.Json;
using Revit.Shared.Entity.Commons.Desensitization;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using Abp.Auditing;
using Abp.Authorization.Users;
using Revit.Authorization.Users;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;

namespace Revit.Shared.Entity.Users
{
    [INotifyPropertyChanged]
    public partial class UserEditDto : IPassivable
    {
        public long? Id { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxSurnameLength)]
        public string Surname { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxUserNameLength)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }

        [StringLength(UserConsts.MaxPhoneNumberLength)]
        public string PhoneNumber { get; set; }

        // Not used "Required" attribute since empty value is used to 'not change password'
        [StringLength(AbpUserBase.MaxPlainPasswordLength)]
        [DisableAuditing]
        public string Password { get; set; }

        public bool IsActive { get; set; }

        public bool ShouldChangePasswordOnNextLogin { get; set; }

        public virtual bool IsTwoFactorEnabled { get; set; }

        public virtual bool IsLockoutEnabled { get; set; }
    }
}
