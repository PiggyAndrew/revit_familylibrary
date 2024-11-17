using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
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
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Revit.Service.Projects
{
    public class ProjectService : BaseService, IProjectService
    {
        private readonly IBaseRepository<R_Project> projectRepository;
        private readonly IBaseRepository<R_User> userRepository;
        private readonly IBaseRepository<R_ProjectUser> projectUserRepository;
        private readonly IBaseRepository<R_ProjectFolder> projectFolderRepository;
        private readonly IMapper mapper;

        public ProjectService(IBaseRepository<R_Project> projectRepository
            , IBaseRepository<R_User> usertRepository, IBaseRepository<R_ProjectUser> projectUserRepository
            , IBaseRepository<R_ProjectFolder> projectFolderRepository
            , IMapper mapper) : base(mapper)
        {
            this.projectRepository = projectRepository;
            this.userRepository = usertRepository;
            this.projectUserRepository = projectUserRepository;
            this.projectFolderRepository = projectFolderRepository;
            this.mapper = mapper;
        }

        /// <summary>
        /// 获取查询条件下的项目
        /// </summary>
        /// <param name="projectRequestDto"></param>
        /// <returns></returns>
        public IEnumerable<ProjectResponseDto> GetProjects(ProjectRequestDto projectRequestDto)
        {
            Expression<Func<R_Project, bool>> predicate = x =>
            string.IsNullOrWhiteSpace(projectRequestDto.SearchMessage)
                || x.ProjectName.Contains(projectRequestDto.SearchMessage);
            var projects = projectRepository.GetList(predicate)
                .Skip((projectRequestDto.PageIndex - 1) * projectRequestDto.PageSize)
                .Take(projectRequestDto.PageSize);
            var results = mapper.Map<List<ProjectResponseDto>>(projects);
            foreach (var project in results)
            {
                var user = userRepository.Get(project.CreatorId);
                var userDto = mapper.Map<AccountDto>(user);
                project.UserDto = userDto;
                var userIds = projectUserRepository.GetList(x => x.ProjectId == project.Id).Select(x => x.UserId);
                var projectSUsers = userRepository.GetList(x => userIds.Contains(x.Id));
                var projectSUsersDto = mapper.Map<List<AccountDto>>(projectSUsers);
                project.ProjectUserCount = projectSUsersDto.Count;
            }
            return results;
        }

        /// <summary>
        /// 创建项目
        /// </summary>
        /// <param name="createDto"></param>
        /// <returns></returns>
        public async Task<ProjectResponseDto> CreateProject(ProjectPostPutDto createDto)
        {
            R_Project project = mapper.Map<R_Project>(createDto); ;
            //// 保存图标在项目文档基础路径下
            //if (createDto.Icon != null && createDto.Icon.Length > 0)
            //{
            //    // 定义文件保存的路径
            //    var basePath = configuration.GetValue<string>(Appsettings.FileSaveBasePath);
            //    var path = Path.Combine(project.BasePath, "images", createDto.Icon.FileName);
            //    var directoryInfo = new DirectoryInfo(Path.GetDirectoryName(path));
            //    if (!directoryInfo.Exists)
            //        directoryInfo.Create();
            //    using (var stream = new FileStream(path, FileMode.CreateNew))
            //    {
            //        await createDto.Icon.CopyToAsync(stream);
            //    }
            //    project.IconPath = path;
            //}
            var result = projectRepository.Add(project);
            var creator = userRepository.Get(createDto.CreatorId);
            if (creator!=null&&result!=null)
            {
                projectUserRepository.Add(new R_ProjectUser() { ProjectId = result.Id, UserId = creator.Id });
            }
            else
            {
                throw new Exception("添加项目失败或用户不存在;");
            }
            var accountDto = mapper.Map<AccountDto>(creator);
            if (result != null)
            {
                //创建项目存储根目录
                CreateProjectRootPath(result);

                //传回结果
                var projectDto = mapper.Map<ProjectResponseDto>(result);
                projectDto.UserDto = accountDto;
                projectDto.ProjectUserCount = 1;
                projectDto.DocumentsSize = 0;

                return projectDto;
            }
            return null;
        }

        public  int ModifyProject(ProjectPostPutDto projectModify)
        {
            var r_project = mapper.Map<R_Project>(projectModify);
            var account = projectRepository.Update(r_project);
            return account;
        }


        private bool CreateProjectRootPath(R_Project createDto)
        {
            // 定义文件保存的路径
            var project = mapper.Map<R_Project>(createDto);
            var baseFolder = new R_ProjectFolder()
            {
                CreationTime = DateTime.Now,
                Name = "项目根目录",
                RelativePath = $"",
                CreatorId = createDto.CreatorId,
                ProjectId = project.Id,
                LastModificationTime = DateTime.Now,
            };
            projectFolderRepository.Add(baseFolder);
            var basePath = @"全部文件";
            var projectBaseFolder = new R_ProjectFolder()
            {
                Name = "全部文件",
                RelativePath = basePath,
                CreatorId = createDto.CreatorId,
                ProjectId = project.Id,
                IsRoot=true
            };
            projectFolderRepository.Add(projectBaseFolder);

            var modelBaseFolder = new R_ProjectFolder()
            {
                Name = "模型",
                RelativePath = Path.Combine(basePath, "模型"),
                CreatorId = createDto.CreatorId,
                ProjectId = project.Id,
            };
            projectFolderRepository.Add(modelBaseFolder);

            var otherBaseFolder = new R_ProjectFolder()
            {
                Name = "其他",
                RelativePath = Path.Combine(basePath, "其他"),
                CreatorId = createDto.CreatorId,
                ProjectId = project.Id,
            };
            projectFolderRepository.Add(otherBaseFolder);

            var drawBaseFolder = new R_ProjectFolder()
            {
                Name = "图纸",
                RelativePath = Path.Combine(basePath, "图纸"),
                CreatorId = createDto.CreatorId,
                ProjectId = project.Id,
            };
            projectFolderRepository.Add(drawBaseFolder);

            return true;
        }

        /// <summary>
        /// 获取项目内的用户
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public  IEnumerable<UserDto> GetProjectUsers(long projectId)
        {
            var userIds = projectUserRepository.GetQueryable().Where(x=>x.ProjectId==projectId).Select(x=>x.UserId);
            var users=new List<R_User>();
            foreach (var userId in userIds)
            {
               var user= userRepository.Get(userId);
                if (user!=null)
                {
                    users.Add(user);
                }
            }
            var results = mapper.Map<List<UserDto>>(users);
            return results;
        }


        /// <summary>
        /// 获取项目内的用户
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public int  DeleteProjectUser(long projectId,long userId)
        {
            var allUsers=projectUserRepository.GetQueryable().Where(x => x.ProjectId == projectId);
            if (allUsers.Count()<=1)
            {
                return 0;
            }
            var count = projectUserRepository.Delete(x => x.ProjectId == projectId&&userId==x.UserId);
            return count;
        }

        /// <summary>
        /// 删除指定项目
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public int DeleteProject(long projectId)
        {
            return projectRepository.Delete(x => x.Id == projectId);
        }


        public async Task<IEnumerable<ProjectFolderDto>> GetRecentlyFiles(long userId)
        {
            var files = projectFolderRepository.GetQueryable()
                .Where(x => !string.IsNullOrWhiteSpace(x.FileExtension) && x.CreatorId == userId);
            if (files != null && files.Any())
            {
                var result = mapper.Map<IEnumerable<ProjectFolderDto>>(files);
            }
            return null;
        }

    


        public UserDto AddProjectUser(long projectId, long userId)
        {
            var projectUser = new R_ProjectUser();
            projectUser.ProjectId = projectId;
            projectUser.UserId = userId;    
            var result = projectUserRepository.Add(projectUser);
            if (result!=null)
            {
                var user = userRepository.Get(userId);
                var userDto = mapper.Map<UserDto>(user);
                return userDto;
            }
            return null;
        }

       
    }
}
