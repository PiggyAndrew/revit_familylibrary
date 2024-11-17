using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.ObjectModel;
using Revit.Service.IServices;
using Prism.Commands;
using Prism.Services.Dialogs;
using Prism.Regions;
using Revit.Application.Views.ProjectViews;
using System.Windows;
using System.Linq;
using Revit.Shared.Entity.Commons;
using Revit.Shared;
using Revit.Shared.Entity.Project;

namespace Revit.Application.ViewModels.ProjectViewModels
{
    public class DisPlayProjectViewModel : ObservableRecipient
    {
        private readonly IProjectService _projectService;
        private readonly IDialogService dialogService;
        private readonly IRegionManager regionManager;
        public ObservableCollection<ProjectDto> _recentlyUserProjects = new ObservableCollection<ProjectDto>();
        public ObservableCollection<ProjectDto> RecentlyUserProjects
        {
            get { return _recentlyUserProjects; }
            set { SetProperty(ref _recentlyUserProjects, value); }
        }

        public ObservableCollection<string> _allUserProjects = new ObservableCollection<string>() { "123", "456" };

        public DelegateCommand<MenuBar> NavigateCommand { get; private set; }

        private DelegateCommand<ProjectDto> _createProjectCommand;

        public DelegateCommand<ProjectDto> CreateProjectCommand
        { get => _createProjectCommand ?? new DelegateCommand<ProjectDto>(CreateProject).ObservesCanExecute(() => IsEnable); }

        private DelegateCommand<ProjectDto> _modifyProjectCommand;



        public DelegateCommand<ProjectDto> ModifyProjectCommand
        { get => _modifyProjectCommand ?? new DelegateCommand<ProjectDto>(ModifyProject).ObservesCanExecute(() => IsEnable); }

        private DelegateCommand<ProjectDto> _deleteProjectCommand;

        public DelegateCommand<ProjectDto> DeleteProjectCommand
        { get => _deleteProjectCommand ?? new DelegateCommand<ProjectDto>(DeleteProject).ObservesCanExecute(() => IsEnable); }

        private DelegateCommand<ProjectDto> _entryProjectCommand;

        public DelegateCommand<ProjectDto> EntryProjectCommand
        { get => _entryProjectCommand ?? new DelegateCommand<ProjectDto>(EntryProject).ObservesCanExecute(() => IsEnable); }

     

        private bool _isEnable = true;

        public bool IsEnable
        {
            get { return _isEnable; }
            set { SetProperty(ref _isEnable, value); }
        }


        private async void CreateProject(ProjectDto projectCreateDto)
        {
            //IsEnable = false;
            dialogService.ShowDialog("ProjectCreateDialog", new DialogParameters(), async (res) =>
            {
                if (res.Result == ButtonResult.OK)
                {
                    var projectDto = res.Parameters.GetValue<ProjectPostPutDto>("createProject");

                    var apiResult = await this._projectService.Create(projectDto);
                    if (true)
                    {
                        RecentlyUserProjects.Add(apiResult.Result);
                        RecentlyUserProjects = new ObservableCollection<ProjectDto>(RecentlyUserProjects);
                    }
                }
            });
        }

        private void EntryProject(ProjectDto dto)
        {
            MessageBox.Show(this.regionManager.Regions.Count().ToString());
            this.regionManager.RequestNavigate("MainContent", nameof(ProjectView));
        }


        private void ModifyProject(ProjectDto dto)
        {
            throw new NotImplementedException();
        }
        private async void DeleteProject(ProjectDto project)
        {
            var apiResult = await this._projectService.Delete(project.Id);
            if (true)
            {
                RecentlyUserProjects.Remove(project);
                RecentlyUserProjects = new ObservableCollection<ProjectDto>(RecentlyUserProjects);
            }
        }



        public DisPlayProjectViewModel(IProjectService projectService
            , IDialogService dialogService
            ,IRegionManager regionManager)
        {
            this._projectService = projectService;
            this.dialogService = dialogService;
            this.regionManager = regionManager;
            Init();
        }

        private void Init()
        {
            InitRecentlyUserProjects();
        }

        private async void InitRecentlyUserProjects()
        {
            var apiResult = await _projectService.GetProjects(new ProjectPageRequestDto() {  UserId = 1 });
            if (true)
            {
                this.RecentlyUserProjects = new ObservableCollection<ProjectDto>(apiResult.Result);
            }
        }
    }
}