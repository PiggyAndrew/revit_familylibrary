using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Org.BouncyCastle.Asn1.Ocsp;
using Revit.Entity.Project;
using Revit.Entity.Users;
using Revit.Repository;
using Revit.Service.Commons;
using Revit.Service.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Service.Projects
{
    public class ProjectFileService : BaseService, IProjectFileService
    {


        private readonly IBaseRepository<R_Project> projectRepository;
        private readonly IBaseRepository<R_User> userRepository;
        private readonly IBaseRepository<R_ProjectUser> projectUserRepository;
        private readonly IBaseRepository<R_ProjectFolder> projectFolderRepository;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;
        private readonly UserManager<R_User> userManager;

        public ProjectFileService(IBaseRepository<R_Project> projectRepository
            , IBaseRepository<R_User> usertRepository, IBaseRepository<R_ProjectUser> projectUserRepository
            , IBaseRepository<R_ProjectFolder> projectFolderRepository
            , IMapper mapper, IConfiguration configuration, UserManager<R_User> userManager) : base(mapper)
        {
            this.projectRepository = projectRepository;
            this.userRepository = usertRepository;
            this.projectUserRepository = projectUserRepository;
            this.projectFolderRepository = projectFolderRepository;
            this.mapper = mapper;
            this.configuration = configuration;
            this.userManager = userManager;
        }


        public async Task<IEnumerable<ProjectFolderDto>> UploadProjectFile(long folderId,long userId, ProjectUploadFileDto projectUploadFileDto)
        {
            var folder = projectFolderRepository.Get(folderId);
            if (folder == null)
            {
                return null;
            }
            var results = new List<ProjectFolderDto>();
            foreach (var file in projectUploadFileDto.Files)
            {
                var newFile = new R_ProjectFolder()
                {
                    ProjectId = folder.ProjectId,
                    Name = Path.GetFileNameWithoutExtension(file.FileName),
                    FileExtension = Path.GetExtension(file.FileName).Trim('.'),
                    FileBytesSize = file.Length, 
                    CreatorId = userId
                };
                string filePath = folder.LocalUrl.AbsolutePath;
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
                using (var stream = new FileStream(Path.Combine(filePath,file.FileName), FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                var result=projectFolderRepository.Add(newFile);
                if (result!=null)
                {
                    var projectFolderDto = mapper.Map<ProjectFolderDto>(result);
                    var user = userRepository.Get(userId);
                    projectFolderDto.CreatorName = user?.FullName ?? "未知用户";
                    results.Add(projectFolderDto);
                }
                else
                {
                    throw new Exception("上传失败");
                }
            }
            return results;
        }



       

        public async Task<FileStream> GetRvtGltfFile(long folderId)
        {
            //var basePath= @"C:\Users\Zero\Documents\GitHub\webapi-revitor\Revit.WebAPI\Base\13";
            //var folder= projectFolderRepository.Get(folderId);
            //if (folder == null||!folder.FileExtension.ToLower().Contains("rvt")) return null;
            //var filePath = Path.Combine(basePath,folder.RelativePath);
            //var savePath = Path.Combine(basePath,Path.GetDirectoryName(folder.RelativePath), "1.glb");
            //var strList = new string[] { @filePath, savePath };
            //var exePath = Path.Combine("C:\\Users\\Zero\\Documents\\GitHubN\\Revit2GLTF\\Test\\bin\\Debug\\net48", "Revit2018.exe");
            ////var result = GltfTransformExtension.StartProcess(exePath, strList);
            //if (true)
            //{
            //    var bytes=File.ReadAllBytes(savePath);
            //    var fileStream=new FileStream(savePath, FileMode.Open);
            //    return fileStream;
            //}
            //else
            //{
            //    return null;
            //}
            return null;
        }
    }
}
