using ImTools;
using Prism.Commands;
using Revit.Entity;
using Revit.Service.IServices;
using Revit.Shared;
using Revit.Shared.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using Revit.Shared.Entity.Project;

namespace Revit.Application.ViewModels.ProjectViewModels
{
    public class ProjectFileManageViewModel : ViewModelBase
    {
        private readonly IProjectFolderService projectFolderService;
        private readonly IProjectFileService projectFileService;

        #region Commands
        private DelegateCommand<ProjectFolderTreeNode> _uploadFilesCommand;

        public DelegateCommand<ProjectFolderTreeNode> UploadFilesCommand
        { get => _uploadFilesCommand ?? new DelegateCommand<ProjectFolderTreeNode>(UploadFiles); }

        private DelegateCommand<ProjectFolderTreeNode> _createFolderCommand;

        public DelegateCommand<ProjectFolderTreeNode> CreateFolderCommand { get => _createFolderCommand ?? new DelegateCommand<ProjectFolderTreeNode>(CreateFolder); }

        private DelegateCommand<ProjectFolderTreeNode> _changeSelectedFolderCommand;
        public DelegateCommand<ProjectFolderTreeNode> ChangeSelectedFolderCommand
        {
            get => _changeSelectedFolderCommand ?? new DelegateCommand<ProjectFolderTreeNode>(ChangeSelectedFolder);
        }

        private DelegateCommand<ProjectFolderTreeNode> _downloadFilesCommand;
        public DelegateCommand<ProjectFolderTreeNode> DownloadFilesCommand
        {
            get => _downloadFilesCommand ?? new DelegateCommand<ProjectFolderTreeNode>(DownloadFiles);
        }

        private DelegateCommand<ProjectFolderTreeNode> _deleteFilesCommand;
        public DelegateCommand<ProjectFolderTreeNode> DeleteFilesCommand
        {
            get => _deleteFilesCommand ?? new DelegateCommand<ProjectFolderTreeNode>(DeleteFiles);
        }


        private DelegateCommand<ProjectFolderDto> _showModelInWebSiteCommand;
        public DelegateCommand<ProjectFolderDto> ShowModelInWebSiteCommand
        {
            get => _showModelInWebSiteCommand ?? new DelegateCommand<ProjectFolderDto>(ShowModelInWebSite);
        }

       


        #endregion

        #region Parameters
        private ObservableCollection<ProjectFolderDto> _projectFolderDtos = new ObservableCollection<ProjectFolderDto>();
        public ObservableCollection<ProjectFolderDto> ProjectFolderDtos
        {
            get { return _projectFolderDtos; }
            set { SetProperty(ref _projectFolderDtos, value); }
        }

        private ObservableCollection<ProjectFolderTreeNode> _projectFolderTreeNodes = new ObservableCollection<ProjectFolderTreeNode>();
        public ObservableCollection<ProjectFolderTreeNode> ProjectFolderTreeNodes
        {
            get { return _projectFolderTreeNodes; }
            set { SetProperty(ref _projectFolderTreeNodes, value); }
        }


       




        #endregion



        public ProjectFileManageViewModel(IProjectFolderService projectFolderService, IProjectFileService projectFileService)
        {
            this.projectFolderService = projectFolderService;
            this.projectFileService = projectFileService;
            //InitFolders();
        }

        #region PrivateMethods
        //private async void InitFolders()
        //{
        //    var result = await projectFolderService.GetFolders(13, new ProjectGetFoldersDto() { RequestPath = "" });
        //    if (true) 
        //    {
        //        ProjectFolderDtos = new ObservableCollection<ProjectFolderDto>(result.Result.Where(x => !x.IsRoot));
        //        ProjectFolderTreeNodes = new ObservableCollection<ProjectFolderTreeNode>(DealFoldersToTreeNode(result.Result.Where(x=>string.IsNullOrWhiteSpace(x.FileExtension))));
        //    }
        //}
        #endregion

        //private List<ProjectFolderTreeNode> DealFoldersToTreeNode(IEnumerable<ProjectFolderDto> folderDtos)
        //{
        //    var rootFolder = folderDtos.FindFirst(x => x.IsRoot);
        //    var root = new ProjectFolderTreeNode() { Name = rootFolder.Name, Value = rootFolder,IsSelected=true };
        //    root = AddPathToTree(root, folderDtos.Where(x => !x.IsRoot));
        //    return new List<ProjectFolderTreeNode>() { root };
        //}

        //public ProjectFolderTreeNode AddPathToTree(ProjectFolderTreeNode parent, IEnumerable<ProjectFolderDto> folders)
        //{
        //    var parentParts = parent.Value.RelativePath.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
        //    foreach (var folder in folders)
        //    {
        //        var folderTreeNode = new ProjectFolderTreeNode() { Name = folder.Name, Value = folder };
        //        var parts = folder.RelativePath.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
        //        //是否比父类大一个层级
        //        if (parts.Count() == (parentParts.Count() + 1) && parts[parentParts.Count() - 1] == parentParts[parentParts.Count() - 1])
        //        {
        //            folderTreeNode = AddPathToTree(folderTreeNode, folders);
        //            parent.Children.Add(folderTreeNode);
        //        }
        //    }
        //    return parent;
        //}


        private void ShowModelInWebSite(ProjectFolderDto folder)
        {
            var folderId = folder.Id;
            if (folder.FileExtension.Contains("rvt"))
            {
                System.Diagnostics.Process.Start($"http://localhost:9527/#/project/index/{folderId}");
            }
        }

        #region CommandMethods

        private async void ChangeSelectedFolder(ProjectFolderTreeNode selectedFolder)
        {


        }


        private async void UploadFiles(ProjectFolderTreeNode projectFolderTreeNode)
        {
            //var folderId=projectFolderTreeNode.Value.Id;
            ////获取文档路径
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "所有文件 (*.*)|*.*";
            //openFileDialog.Title = "选择一个文件";
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    var filePaths = openFileDialog.FileNames.ToList();
            //    var result = await projectFileService.UploadFilesAsync(folderId, new UploadFileDtoBase() { FilesPath=filePaths});
            //    if (true)
            //    {
            //        ProjectFolderDtos = new ObservableCollection<ProjectFolderDto>(ProjectFolderDtos.AddRange(result.Result));
            //    }
            //    else
            //    {
            //        ProjectFolderDtos = new ObservableCollection<ProjectFolderDto>();
            //    }
            //}
        }



        private async void CreateFolder(ProjectFolderTreeNode projectFolderTreeNode)
        {
            //var result = await projectFolderService.CreateFolder(13, new ProjectCreateFolderDto() { FolderName = projectFolderTreeNode.Name,  CreatorId=Global.User.UserId, FolderId= projectFolderTreeNode.Value.Id });
            //if (true)
            //{
            //    ProjectFolderDtos.Add(result.Result);
            //    ProjectFolderDtos = new ObservableCollection<ProjectFolderDto>(ProjectFolderDtos);
            //     AddPathToTree(projectFolderTreeNode, new List<ProjectFolderDto>() { result.Result } );
            //}
            //else
            //{
            //    ProjectFolderDtos = new ObservableCollection<ProjectFolderDto>();
            //}
        }


        private void DownloadFiles(ProjectFolderTreeNode node)
        {
            throw new NotImplementedException();
        }


        private void DeleteFiles(ProjectFolderTreeNode node)
        {
            
        }

        #endregion




    }
}
