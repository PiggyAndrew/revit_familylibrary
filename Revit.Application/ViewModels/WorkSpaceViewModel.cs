using Revit.Accounts.Dto;
using Revit.Entity;
using Revit.Service.IServices;
using Revit.Shared;
using Revit.Shared.Entity.Commons;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Revit.Shared.Entity.Project;

namespace Revit.Application.ViewModels
{
    public class WorkSpaceViewModel : ViewModelBase
    {
        private LoginedUserDto _loginUserDto;
        private readonly IAccountService _userService;
        private readonly IProjectService projectService;

        public LoginedUserDto LoginUserDto
        {
            get { return _loginUserDto; }
            set { SetProperty(ref _loginUserDto, value); }
        }



        //[ObservableProperty]
        //public LoginedUserDto _loginedUser = new LoginedUserDto() { UserName = "严冬", Account = "188****3248" };


        //[ObservableProperty]
        //public DateTime _currentDate = DateTime.Now;

        //[ObservableProperty]
        //public DateTime _currentDateHours = DateTime.Now.Date;

        //[ObservableProperty]
        //public int _projectCount = 0;

        //[ObservableProperty]
        //public int _myTaskCount = 0;


        public ObservableCollection<ProjectFolderDto> _recentlyFiles = new ObservableCollection<ProjectFolderDto>();
        public ObservableCollection<ProjectFolderDto> RecentlyFiles
        {
            get { return _recentlyFiles; }
            set { SetProperty(ref _recentlyFiles, value); }
        }

        //[ObservableProperty]
        //public ObservableCollection<string> _recentlyNews = new ObservableCollection<string>() { "123", "456" };

        //[ObservableProperty]
        //public ObservableCollection<string> _recentlyTasks = new ObservableCollection<string>() { "123", "456" };

        public WorkSpaceViewModel(IAccountService userService, IProjectService projectService)
        {
            this._userService = userService;
            this.projectService = projectService;
            Init();
        }


        private async void InitUser()
        {
            LoginUserDto = Global.User;
        }


        #region PrivateMethod

        private void Init()
        {
            InitUser();
            InitRecentlyProjects();
            //InitRecentlyNews();
            //InitRecentlyTasks();
        }

        private void InitRecentlyTasks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 初始化最新动态
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void InitRecentlyNews()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 初始化最近项目
        /// </summary>
        private async Task InitRecentlyProjects()
        {
            var result = await projectService.GetRecentlyFiles(Global.User.UserId);

        }


        #endregion

    }
}
