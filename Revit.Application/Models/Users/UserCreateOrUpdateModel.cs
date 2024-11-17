using System.Collections.Generic;
using AppFramework.Admin.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Revit.Application.Models.Users
{
    [INotifyPropertyChanged]
    public partial class UserCreateOrUpdateModel 
    {
        [ObservableProperty]
        private bool sendActivationEmail;

        [ObservableProperty]
        private bool setRandomPassword;
         
        public UserEditModel User { get; set; }

        //public string[] AssignedRoleNames { get; set; }
         
        //public List<long> OrganizationUnits { get; set; }

        public UserCreateOrUpdateModel()
        {
            //OrganizationUnits = new List<long>();
        }
    }
}