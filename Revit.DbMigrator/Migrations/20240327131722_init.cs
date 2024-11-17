using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "R_Permission",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false, comment: "权限名称"),
                    Code = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false, comment: "权限编码"),
                    Url = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true, comment: "Url地址"),
                    Component = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true, comment: "Vue页面组件"),
                    Icon = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true, comment: "图标"),
                    PermissionType = table.Column<int>(type: "INTEGER", nullable: false, comment: "菜单类型,0：菜单权限、元素权限、Api权限、数据权限"),
                    ApiMethod = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true, comment: "API方法：GET、PUT、POST、DELETE"),
                    Sort = table.Column<int>(type: "INTEGER", nullable: false, comment: "排序"),
                    ParentId = table.Column<long>(type: "INTEGER", nullable: false, comment: "父菜单Id"),
                    Status = table.Column<int>(type: "INTEGER", nullable: false, comment: "状态，0：禁用，1：正常"),
                    Remark = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true, comment: "备注"),
                    CreatorId = table.Column<long>(type: "INTEGER", nullable: false, comment: "创建者Id"),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "创建时间"),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "最后编辑时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_Permission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "R_Project",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProjectName = table.Column<string>(type: "TEXT", nullable: false, comment: "项目名称"),
                    ProjectAddress = table.Column<string>(type: "TEXT", nullable: false, comment: "项目地址"),
                    Introduction = table.Column<string>(type: "TEXT", nullable: false, comment: "项目介绍"),
                    IconPath = table.Column<string>(type: "TEXT", nullable: false, comment: "图标路径"),
                    CreatorId = table.Column<long>(type: "INTEGER", nullable: false, comment: "创建者Id"),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "创建时间"),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "最后编辑时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "R_ProjectFolder",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false, comment: "文件名称无后缀"),
                    FileExtension = table.Column<string>(type: "TEXT", nullable: false, comment: "后缀名称"),
                    FileSize = table.Column<string>(type: "TEXT", nullable: false, comment: "文件大小"),
                    ProjectId = table.Column<long>(type: "INTEGER", nullable: false, comment: "项目Id"),
                    RelativePath = table.Column<string>(type: "TEXT", nullable: false, comment: "相对路径"),
                    IsRoot = table.Column<bool>(type: "INTEGER", nullable: false, comment: "是否为根路径"),
                    CreatorId = table.Column<long>(type: "INTEGER", nullable: false, comment: "创建者Id"),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "创建时间"),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "最后编辑时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_ProjectFolder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "R_Role",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatorId = table.Column<long>(type: "INTEGER", nullable: false, comment: "创建者Id"),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "创建时间"),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "最后编辑时间"),
                    Status = table.Column<int>(type: "INTEGER", nullable: false, comment: "状态，0：禁用，1：正常"),
                    Remark = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true, comment: "备注"),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "R_User",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatorId = table.Column<long>(type: "INTEGER", nullable: false, comment: "创建者Id"),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "创建时间"),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "最后编辑时间"),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    Remark = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "R_RoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<long>(type: "INTEGER", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_RoleClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_R_RoleClaim_R_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "R_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "R_RolePermission",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<long>(type: "INTEGER", nullable: false),
                    PermissionId = table.Column<long>(type: "INTEGER", nullable: false),
                    CreatorId = table.Column<long>(type: "INTEGER", nullable: false, comment: "创建者Id"),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "创建时间"),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "最后编辑时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_RolePermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_R_RolePermission_R_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "R_Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_R_RolePermission_R_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "R_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "R_ProjectUser",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProjectId = table.Column<long>(type: "INTEGER", nullable: false, comment: "项目Id"),
                    UserId = table.Column<long>(type: "INTEGER", nullable: false, comment: "用户Id"),
                    CreatorId = table.Column<long>(type: "INTEGER", nullable: false, comment: "创建者Id"),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "创建时间"),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "最后编辑时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_ProjectUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_R_ProjectUser_R_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "R_Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_R_ProjectUser_R_User_UserId",
                        column: x => x.UserId,
                        principalTable: "R_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "R_UserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<long>(type: "INTEGER", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_UserClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_R_UserClaim_R_User_UserId",
                        column: x => x.UserId,
                        principalTable: "R_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "R_UserLogin",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_UserLogin", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_R_UserLogin_R_User_UserId",
                        column: x => x.UserId,
                        principalTable: "R_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "R_UserRole",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "INTEGER", nullable: false),
                    RoleId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_R_UserRole_R_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "R_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_R_UserRole_R_User_UserId",
                        column: x => x.UserId,
                        principalTable: "R_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "R_UserToken",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "INTEGER", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_UserToken", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_R_UserToken_R_User_UserId",
                        column: x => x.UserId,
                        principalTable: "R_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "R_Permission",
                columns: new[] { "Id", "ApiMethod", "Code", "Component", "CreationTime", "CreatorId", "Icon", "LastModificationTime", "Name", "ParentId", "PermissionType", "Remark", "Sort", "Status", "Url" },
                values: new object[] { 1L, "", "system", "", new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9500), 0L, "el-icon-s-tools", new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9515), "系统管理", 0L, 0, null, 0, 1, "system" });

            migrationBuilder.InsertData(
                table: "R_Permission",
                columns: new[] { "Id", "ApiMethod", "Code", "Component", "CreationTime", "CreatorId", "Icon", "LastModificationTime", "Name", "ParentId", "PermissionType", "Remark", "Sort", "Status", "Url" },
                values: new object[] { 2L, "", "system.user", "views/documentation/index", new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9527), 0L, "el-icon-user-solid", new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9528), "用户管理", 1L, 0, null, 0, 1, "system.user" });

            migrationBuilder.InsertData(
                table: "R_Permission",
                columns: new[] { "Id", "ApiMethod", "Code", "Component", "CreationTime", "CreatorId", "Icon", "LastModificationTime", "Name", "ParentId", "PermissionType", "Remark", "Sort", "Status", "Url" },
                values: new object[] { 3L, "", "system.role", "views/documentation/index", new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9530), 0L, "peoples", new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9531), "角色管理", 1L, 0, null, 0, 1, "role" });

            migrationBuilder.InsertData(
                table: "R_Permission",
                columns: new[] { "Id", "ApiMethod", "Code", "Component", "CreationTime", "CreatorId", "Icon", "LastModificationTime", "Name", "ParentId", "PermissionType", "Remark", "Sort", "Status", "Url" },
                values: new object[] { 4L, "", "system.permission", "views/documentation/index", new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9533), 0L, "list", new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9533), "菜单管理", 1L, 0, null, 0, 1, "permission" });

            migrationBuilder.InsertData(
                table: "R_Permission",
                columns: new[] { "Id", "ApiMethod", "Code", "Component", "CreationTime", "CreatorId", "Icon", "LastModificationTime", "Name", "ParentId", "PermissionType", "Remark", "Sort", "Status", "Url" },
                values: new object[] { 5L, "", "system.rolepermission", "views/documentation/index", new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9537), 0L, "example", new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9537), "角色权限", 1L, 0, null, 0, 1, "rolepermission" });

            migrationBuilder.InsertData(
                table: "R_Project",
                columns: new[] { "Id", "CreationTime", "CreatorId", "IconPath", "Introduction", "LastModificationTime", "ProjectAddress", "ProjectName" },
                values: new object[] { 1L, new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5717), 1L, "", "", new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5714), "", "测试1" });

            migrationBuilder.InsertData(
                table: "R_Project",
                columns: new[] { "Id", "CreationTime", "CreatorId", "IconPath", "Introduction", "LastModificationTime", "ProjectAddress", "ProjectName" },
                values: new object[] { 2L, new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5746), 1L, "", "", new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5728), "", "测试2" });

            migrationBuilder.InsertData(
                table: "R_Project",
                columns: new[] { "Id", "CreationTime", "CreatorId", "IconPath", "Introduction", "LastModificationTime", "ProjectAddress", "ProjectName" },
                values: new object[] { 3L, new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5755), 1L, "", "", new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5752), "", "测试3" });

            migrationBuilder.InsertData(
                table: "R_Project",
                columns: new[] { "Id", "CreationTime", "CreatorId", "IconPath", "Introduction", "LastModificationTime", "ProjectAddress", "ProjectName" },
                values: new object[] { 4L, new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5760), 1L, "", "", new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5758), "", "测试4" });

            migrationBuilder.InsertData(
                table: "R_Project",
                columns: new[] { "Id", "CreationTime", "CreatorId", "IconPath", "Introduction", "LastModificationTime", "ProjectAddress", "ProjectName" },
                values: new object[] { 5L, new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5767), 1L, "", "", new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5764), "", "测试5" });

            migrationBuilder.InsertData(
                table: "R_Project",
                columns: new[] { "Id", "CreationTime", "CreatorId", "IconPath", "Introduction", "LastModificationTime", "ProjectAddress", "ProjectName" },
                values: new object[] { 6L, new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5774), 1L, "", "", new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5772), "", "测试6" });

            migrationBuilder.InsertData(
                table: "R_Role",
                columns: new[] { "Id", "ConcurrencyStamp", "CreationTime", "CreatorId", "LastModificationTime", "Name", "NormalizedName", "Remark", "Status" },
                values: new object[] { 1L, "edca20fc-8a40-4922-b394-89090c2907f2", new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(6019), 0L, new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5863), "管理员", "管理员", null, 1 });

            migrationBuilder.InsertData(
                table: "R_User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationTime", "CreatorId", "Email", "EmailConfirmed", "FullName", "LastModificationTime", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Remark", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1L, 0, "12daf2cb-78d0-4047-9f60-ff3e52927696", new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(6154), 0L, "admin@R_tric.com", true, "管理员", new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(6141), false, null, "ADMIN@R_TRIC.COM", "ADMIN", "AQAAAAEAACcQAAAAELvDyAVZFCjr2SQGCBh3p7CRPXHN/cuNNI8Iun6TwZ4H9ZYNvPLeVoJYBIBJxqliVw==", "123456789", false, null, "abc", 1, false, "admin" });

            migrationBuilder.InsertData(
                table: "R_ProjectUser",
                columns: new[] { "Id", "CreationTime", "CreatorId", "LastModificationTime", "ProjectId", "UserId" },
                values: new object[] { 1L, new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5244), 0L, new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5264), 1L, 1L });

            migrationBuilder.InsertData(
                table: "R_RolePermission",
                columns: new[] { "Id", "CreationTime", "CreatorId", "LastModificationTime", "PermissionId", "RoleId" },
                values: new object[] { 1L, new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9606), 0L, new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9606), 1L, 1L });

            migrationBuilder.InsertData(
                table: "R_RolePermission",
                columns: new[] { "Id", "CreationTime", "CreatorId", "LastModificationTime", "PermissionId", "RoleId" },
                values: new object[] { 2L, new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9610), 0L, new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9611), 2L, 1L });

            migrationBuilder.InsertData(
                table: "R_RolePermission",
                columns: new[] { "Id", "CreationTime", "CreatorId", "LastModificationTime", "PermissionId", "RoleId" },
                values: new object[] { 3L, new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9612), 0L, new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9612), 3L, 1L });

            migrationBuilder.InsertData(
                table: "R_RolePermission",
                columns: new[] { "Id", "CreationTime", "CreatorId", "LastModificationTime", "PermissionId", "RoleId" },
                values: new object[] { 4L, new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9613), 0L, new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9614), 4L, 1L });

            migrationBuilder.InsertData(
                table: "R_RolePermission",
                columns: new[] { "Id", "CreationTime", "CreatorId", "LastModificationTime", "PermissionId", "RoleId" },
                values: new object[] { 5L, new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9615), 0L, new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9615), 5L, 1L });

            migrationBuilder.InsertData(
                table: "R_UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1L, 1L });

            migrationBuilder.CreateIndex(
                name: "IX_R_Permission_Code",
                table: "R_Permission",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_R_Permission_ParentId",
                table: "R_Permission",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_R_Permission_Sort",
                table: "R_Permission",
                column: "Sort");

            migrationBuilder.CreateIndex(
                name: "IX_R_ProjectUser_ProjectId",
                table: "R_ProjectUser",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_R_ProjectUser_UserId",
                table: "R_ProjectUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "R_Role",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_R_RoleClaim_RoleId",
                table: "R_RoleClaim",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_R_RolePermission_PermissionId",
                table: "R_RolePermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_R_RolePermission_RoleId",
                table: "R_RolePermission",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "R_User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "R_User",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_R_UserClaim_UserId",
                table: "R_UserClaim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_R_UserLogin_UserId",
                table: "R_UserLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_R_UserRole_RoleId",
                table: "R_UserRole",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "R_ProjectFolder");

            migrationBuilder.DropTable(
                name: "R_ProjectUser");

            migrationBuilder.DropTable(
                name: "R_RoleClaim");

            migrationBuilder.DropTable(
                name: "R_RolePermission");

            migrationBuilder.DropTable(
                name: "R_UserClaim");

            migrationBuilder.DropTable(
                name: "R_UserLogin");

            migrationBuilder.DropTable(
                name: "R_UserRole");

            migrationBuilder.DropTable(
                name: "R_UserToken");

            migrationBuilder.DropTable(
                name: "R_Project");

            migrationBuilder.DropTable(
                name: "R_Permission");

            migrationBuilder.DropTable(
                name: "R_Role");

            migrationBuilder.DropTable(
                name: "R_User");
        }
    }
}
