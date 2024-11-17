using System.Collections.ObjectModel;
using Revit.Service.IServices;
using Prism.Commands;
using System.Windows;
using Revit.Shared.Entity.Commons;
using Revit.Shared.Entity.Users;
using Revit.Shared;
using Revit.Shared.Entity.Users;

namespace Revit.Application.ViewModels.ProjectViewModels
{
    public class ProjectMemberViewModel : ViewModelBase
    {
        private readonly IProjectService projectService;

        #region Parameters
        private ObservableCollection<UserDto> _projectUsers = new ObservableCollection<UserDto>();
        public ObservableCollection<UserDto> ProjectUsers
        {
            get { return _projectUsers; }
            set { SetProperty(ref _projectUsers, value); }
        }
        #endregion
        #region Commands
        private DelegateCommand<UserDto> _deleteUserCommand;

        public DelegateCommand<UserDto> DeleteUserCommand { get => _deleteUserCommand ?? new DelegateCommand<UserDto>(DeleteUser); }


        #endregion




        public ProjectMemberViewModel( IProjectService projectService)
        {
            this.projectService = projectService;
            InitProjectUsers();
        }

        private async void InitProjectUsers()
        {
            var result = await projectService.GetUsers(15);
            if (true)
            {
                ProjectUsers = new ObservableCollection<UserDto>();
            }
        }

        private async void DeleteUser(UserDto dto)
        {
            var dialogResult = MessageBox.Show("是否确认删除该品？", "提示", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                var result = await projectService.DeleteUser(13, dto.Id);
                if (true)
                {
                    MessageBox.Show("成功删除", "提示");
                }
                else
                {
                    MessageBox.Show("无法删除最后一个成员", "提示");
                }
            }
        }

    }
}
