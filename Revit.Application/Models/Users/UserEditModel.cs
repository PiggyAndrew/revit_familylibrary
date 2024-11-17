using CommunityToolkit.Mvvm.ComponentModel;

namespace Revit.Application.Models.Users
{
    [INotifyPropertyChanged]
    public partial class UserEditModel 
    {
        [ObservableProperty]
        private string phoneNumber;

        [ObservableProperty]
        private string userName;

        [ObservableProperty]
        private string password;

        [ObservableProperty]
        private string name;

        [ObservableProperty]
        private string surname;

        [ObservableProperty]
        private string emailAddress;

        [ObservableProperty] 
        private bool isActive;

        [ObservableProperty]
        private bool shouldChangePasswordOnNextLogin;

        [ObservableProperty]
        private bool isTwoFactorEnabled;

        [ObservableProperty]
        private bool isLockoutEnabled;

        public long? Id { get; set; } 
    }
}