using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Revit.Entity.Family;
using Revit.Entity.Permissions;
using Revit.Entity.Problem;
using Revit.Entity.Project;
using Revit.Entity.Roles;
using Revit.Entity.Users;
using Revit.Shared.Entity.Permissions;
using System.Reflection.Emit;
using Revit.Shared.Entity.Family;

namespace Revit.EntityFrameworkCore
{
    public class ApplicationDbContext : IdentityDbContext<R_User, R_Role, long
        , R_UserClaim, R_UserRole, R_UserLogin, R_RoleClaim, R_UserToken>
    {

        public DbSet<R_RolePermission> R_RolePermission { get; set; }
        public DbSet<R_Permission> R_Permission { get; set; }
        public DbSet<R_Project> R_Project { get; set; }
        public DbSet<R_ProjectUser> R_ProjectUser { get; set; }
        public DbSet<R_Problem> R_Problem { get; set; }
        public DbSet<R_Family> R_Family { get; set; }
        public DbSet<R_Category> R_Category { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            CreateTable(modelBuilder);
            SetProperties(modelBuilder);
            InitialData(modelBuilder);
        }

        private void CreateTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<R_User>().ToTable("R_User");

            modelBuilder.Entity<R_UserLogin>().ToTable("R_UserLogin");
            modelBuilder.Entity<R_UserClaim>().ToTable("R_UserClaim");
            modelBuilder.Entity<R_UserToken>().ToTable("R_UserToken");

            modelBuilder.Entity<R_Role>().ToTable("R_Role");

            modelBuilder.Entity<R_RoleClaim>().ToTable("R_RoleClaim");

            modelBuilder.Entity<R_UserRole>().ToTable("R_UserRole");

            modelBuilder.Entity<R_Project>().ToTable("R_Project");

            modelBuilder.Entity<R_ProjectUser>().ToTable("R_ProjectUser");
            modelBuilder.Entity<R_ProjectFolder>().ToTable("R_ProjectFolder");
            modelBuilder.Entity<R_Problem>().ToTable("R_Problem");
            modelBuilder.Entity<R_Family>().ToTable("R_Family");
            modelBuilder.Entity<R_Category>().ToTable("R_Category");
            modelBuilder.Entity<R_FamilyCategory>().ToTable("R_FamilyCategory");
        }

        private void SetProperties(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<R_Category>(entity =>
            {
                entity.HasMany<R_FamilyCategory>().WithOne().HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Cascade);
                entity.Property(x => x.CategoryType).IsRequired();
                entity.Property(x => x.Name).IsRequired().HasMaxLength(100);
            });


            modelBuilder.Entity<R_Family>(entity =>
            {
                entity.HasMany<R_FamilyUser>().WithOne().HasForeignKey(x => x.FamilyId).OnDelete(DeleteBehavior.Cascade);
                entity.HasMany<R_FamilyCategory>().WithOne().HasForeignKey(x => x.FamilyId).OnDelete(DeleteBehavior.Cascade);
                entity.Property(x => x.FileExtension).IsRequired();
                entity.Property(x => x.Name).IsRequired().HasMaxLength(100);
                entity.Property(x=>x.SaveUrl).IsRequired(false);
                entity.Property(x=>x.BackUpUrl).IsRequired(false);
                entity.Property(x=>x.MainPhotoUrl).IsRequired(false);
            });

            modelBuilder.Entity<R_ProjectFolder>(entity =>
            {
                entity.Property(x => x.SaveUrl).IsRequired();
                entity.Property(x => x.ProjectId).IsRequired();
                entity.Property(x => x.FileExtension).IsRequired();
                entity.Property(x => x.Name).IsRequired();
            });

            modelBuilder.Entity<R_Project>(entity =>
            {
                entity.HasMany<R_ProjectUser>().WithOne().HasForeignKey(x => x.ProjectId).OnDelete(DeleteBehavior.Cascade);
            });

            //设定字段长度
            modelBuilder.Entity<R_Role>(entity =>
            {
                entity.Property(r => r.Name).HasMaxLength(100);
                entity.Property(r => r.NormalizedName).HasMaxLength(100);
            });
            modelBuilder.Entity<R_User>(entity =>
            {
                entity.Property(r => r.UserName).HasMaxLength(100);
                entity.Property(r => r.NormalizedUserName).HasMaxLength(100);

                entity.HasMany<R_ProjectUser>().WithOne().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);

            });
            //1. 指定外键关系
            modelBuilder.Entity<R_Role>(entity =>
            {
                //指定角色与角色权限表，一对多
                entity.HasMany<R_RolePermission>().WithOne().HasForeignKey(x => x.RoleId).OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<R_Permission>(entity =>
            {
                //指定权限与角色权限表，一对多
                entity.HasMany<R_RolePermission>().WithOne().HasForeignKey(x => x.PermissionId).OnDelete(DeleteBehavior.Cascade);
            });
        }

        private void InitialData(ModelBuilder modelBuilder)
        {
            var adminRoleId = 1;

            modelBuilder.Entity<R_Category>().HasData(
               new R_Category()
               {
                   Id=1,
                   Name = "全部",
                   CategoryType = CategoryType.Keyword,
               });


            modelBuilder.Entity<R_ProjectUser>().HasData(
               new R_ProjectUser()
               {
                   Id = 1,
                   ProjectId = 1,
                   UserId = 1
               });
            modelBuilder.Entity<R_Project>().HasData(
                new R_Project()
                {
                    ProjectName = "测试1",
                    Id = 1,
                    CreatorId = 1,
                    CreationTime = DateTime.Now
                }, new R_Project()
                {
                    ProjectName = "测试2",
                    Id = 2,
                    CreatorId = 1,
                    CreationTime = DateTime.Now
                }, new R_Project()
                {
                    ProjectName = "测试3",
                    Id = 3,
                    CreatorId = 1,
                    CreationTime = DateTime.Now
                }, new R_Project()
                {
                    ProjectName = "测试4",
                    Id = 4,
                    CreatorId = 1,
                    CreationTime = DateTime.Now
                }, new R_Project()
                {
                    ProjectName = "测试5",
                    Id = 5,
                    CreatorId = 1,
                    CreationTime = DateTime.Now
                }, new R_Project()
                {
                    ProjectName = "测试6",
                    Id = 6,
                    CreatorId = 1,
                    CreationTime = DateTime.Now
                });



            // 2. 添加角色
            modelBuilder.Entity<R_Role>().HasData(
                new R_Role
                {
                    Id = adminRoleId,
                    CreationTime = DateTime.Now,
                    Name = "admin",
                    NormalizedName = "admin".ToUpper(),
                    Status = RoleStatus.Normal
                }
            );

            // 3. 添加用户
            var adminUserId = 1;
            R_User adminUser = new R_User
            {
                Id = adminUserId,
                CreationTime = DateTime.Now,
                UserName = "admin",
                NormalizedUserName = "admin".ToUpper(),
                Email = "admin@R_tric.com",
                NormalizedEmail = "admin@R_tric.com".ToUpper(),
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = false,
                SecurityStamp = "abc",
                FullName = "管理员",
                Status = UserStatus.Normal
            };

            PasswordHasher<R_User> ph = new PasswordHasher<R_User>();
            adminUser.PasswordHash = ph.HashPassword(adminUser, "Abc123@");
            modelBuilder.Entity<R_User>().HasData(adminUser);

            // 4. 给用户加入管理员权限
            modelBuilder.Entity<R_UserRole>()
                .HasData(new R_UserRole()
                {
                    RoleId = adminRoleId,
                    UserId = adminUserId
                });

            //5. 初始化权限
            var permissionList = new List<R_Permission>
{
    new R_Permission()
    {
        Id = 1,
        Name = "系统管理",
        Code = "system",
        Url = "system",
        Component = "",
        Icon = "el-icon-s-tools",
        PermissionType = PermissionType.Menu,
        ApiMethod = "",
        Sort = 0,
        ParentId = 0,
        Status = PermissionStatus.Normal
    },
    new R_Permission()
    {
        Id = 2,
        Name = "用户管理",
        Code = "system.user",
        Url = "system.user",
        Component = "views/documentation/index",
        Icon = "el-icon-user-solid",
        PermissionType = PermissionType.Menu,
        ApiMethod = "",
        Sort = 0,
        ParentId = 1,
        Status = PermissionStatus.Normal
    },
    new R_Permission()
    {
        Id = 3,
        Name = "角色管理",
        Code = "system.role",
        Url = "role",
        Component = "views/documentation/index",
        Icon = "peoples",
        PermissionType = PermissionType.Menu,
        ApiMethod = "",
        Sort = 0,
        ParentId = 1,
        Status = PermissionStatus.Normal
    },
    new R_Permission()
    {
        Id = 4,
        Name = "菜单管理",
        Code = "system.permission",
        Url = "permission",
        Component = "views/documentation/index",
        Icon = "list",
        PermissionType = PermissionType.Menu,
        ApiMethod = "",
        Sort = 0,
        ParentId = 1,
        Status = PermissionStatus.Normal
    }
    ,
    new R_Permission()
    {
        Id = 5,
        Name = "角色权限",
        Code = "system.rolepermission",
        Url = "rolepermission",
        Component = "views/documentation/index",
        Icon = "example",
        PermissionType = PermissionType.Menu,
        ApiMethod = "",
        Sort = 0,
        ParentId = 1,
        Status = PermissionStatus.Normal
    }
};
            modelBuilder.Entity<R_Permission>().HasData(permissionList);

            // 6. 给角色分配权限
            var rolePermissionList = new List<R_RolePermission>();
            foreach (var permission in permissionList)
            {
                rolePermissionList.Add(new R_RolePermission()
                {
                    Id = permission.Id,
                    RoleId = adminRoleId,
                    PermissionId = permission.Id
                });
            }
            modelBuilder.Entity<R_RolePermission>()
                .HasData(rolePermissionList);
        }

    }
}
