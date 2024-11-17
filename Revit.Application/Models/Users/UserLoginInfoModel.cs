using CommunityToolkit.Mvvm.ComponentModel;

namespace Revit.Application.Models.Users
{
    [INotifyPropertyChanged]
    public partial class UserLoginInfoModel 
    {
        [ObservableProperty]
        private string name;

        [ObservableProperty]
        private string surname;

        [ObservableProperty]
        private string userName;

        [ObservableProperty]
        private string emailAddress;
         
        public string ProfilePictureId { get; set; }
    }
}
