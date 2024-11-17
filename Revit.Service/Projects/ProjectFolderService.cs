using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Revit.Entity.Accounts;
using Revit.Entity.Commons;
using Revit.Entity.Project;
using Revit.Entity.Users;
using Revit.EntityFrameworkCore;
using Revit.Repository;
using Revit.Service.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Revit.Service.Projects
{
    public class ProjectFolderService : BaseService, IProjectFolderService
    {
        private readonly IBaseRepository<R_Project> projectRepository;
        private readonly IBaseRepository<R_User> userRepository;
        private readonly IBaseRepository<R_ProjectUser> projectUserRepository;
        private readonly IBaseRepository<R_ProjectFolder> projectFolderRepository;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;

        public ProjectFolderService(IBaseRepository<R_Project> projectRepository
            , IBaseRepository<R_User> usertRepository, IBaseRepository<R_ProjectUser> projectUserRepository
            , IBaseRepository<R_ProjectFolder> projectFolderRepository
            , IMapper mapper, IConfiguration configuration) : base(mapper)
        {
            this.projectRepository = projectRepository;
            this.userRepository = usertRepository;
            this.projectUserRepository = projectUserRepository;
            this.projectFolderRepository = projectFolderRepository;
            this.mapper = mapper;
            this.configuration = configuration;
        }

        /// <summary>
        /// 获取项目的文档
        /// </summary>
        /// <param name="projectGetFileDto"></param>
        /// <returns></returns>
        public List<ProjectFolderDto> GetProjectPathFolders(long projectId, ProjectGetFoldersDto projectGetFileDto)
        {
            string requestPath = projectGetFileDto.RequestPath??"";
            if (string.IsNullOrWhiteSpace(requestPath))
            {
                requestPath = "";
            }
            var project = projectRepository.Get(projectId);
            if (project == null) return null;
            var folderModels = projectFolderRepository.GetQueryable().Where(x => x.ProjectId == project.Id);
            folderModels= folderModels.Where(x=>(x.RelativePath.Contains(requestPath.Trim()) && x.RelativePath!=requestPath)
            ||(string.IsNullOrWhiteSpace(requestPath)&&!string.IsNullOrWhiteSpace( x.RelativePath)));
            var results = mapper.Map<List<ProjectFolderDto>>(folderModels);
            foreach (var result in results)
            {
                var user = userRepository.Get(result.CreatorId);
                if (user != null)
                {
                    result.CreatorName = user.FullName ?? "未知用户";
                }
            }
            return results;
        }


        /// <summary>
        /// 创建项目中的文档
        /// </summary>
        /// <param name="createFolderDto"></param>
        /// <returns></returns>
        public ProjectFolderDto CreateProjectFolder(long projectId, ProjectCreateFolderDto createFolderDto)
        {
            var folder = projectFolderRepository.Get(createFolderDto.FolderId);
            if (folder == null)
            {
                return null;
            }
            var hasParentFolder = projectFolderRepository.GetQueryable()
                .Any(x => x.ProjectId == projectId && x.LocalUrl.Contains(folder.RelativePath));
            if (hasParentFolder)
            {
                var user=userRepository.Get(createFolderDto.CreatorId);
                var newFolder = new R_ProjectFolder()
                {
                    Name = createFolderDto.FolderName,
                    RelativePath = Path.Combine(folder.RelativePath, createFolderDto.FolderName),
                    CreatorId = createFolderDto.CreatorId,
                    ProjectId = projectId
                };
                var result = projectFolderRepository.Add(newFolder);
                var projectFolderDto = mapper.Map<ProjectFolderDto>(result);
                projectFolderDto.CreatorName = user.FullName;
                return projectFolderDto;
            }
            return null;
        }


        public int DeleteProjectFolder(long folderId)
        {
            var folder = projectFolderRepository.Get(folderId);
            if (folder != null)
            {
                return projectFolderRepository.Delete(folder);
            }
            throw new HttpRequestException("未找到删除文件夹", new DirectoryNotFoundException(), HttpStatusCode.NotFound);
        }


    }
}
