using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "R_Problem",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RelativeFileId = table.Column<long>(type: "INTEGER", nullable: false, comment: "相关文件Id"),
                    EmergencyDegree = table.Column<int>(type: "INTEGER", nullable: false, comment: "紧急程度"),
                    Discription = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false, comment: "问题描述"),
                    Deadline = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "截止日期"),
                    ProblemStatus = table.Column<int>(type: "INTEGER", nullable: false, comment: "问题状态"),
                    ResponsibleId = table.Column<long>(type: "INTEGER", nullable: false, comment: "责任人Id"),
                    VerifierId = table.Column<long>(type: "INTEGER", nullable: false, comment: "审核人Id"),
                    CreatorId = table.Column<long>(type: "INTEGER", nullable: false, comment: "创建者Id"),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "创建时间"),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "最后编辑时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_Problem", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5355), new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5383), new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5386), new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5387) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5388), new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5392), new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(9329), new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(9336), new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(9338), new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(9342), new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(9352), new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(9354), new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(8720), new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "Name", "NormalizedName" },
                values: new object[] { "7462ab23-9dc5-48e3-bdd2-c3d733b8e278", new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(9656), new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(9418), "admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5487), new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5487) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5492), new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5494), new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5495), new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5496) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5497), new DateTime(2024, 5, 4, 22, 33, 27, 447, DateTimeKind.Local).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "PasswordHash" },
                values: new object[] { "75543467-8555-4b9a-a2e9-b1a7ca0c99f2", new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(9794), new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(9782), "AQAAAAEAACcQAAAAEOuFLkMMDXx8dNe4sN2fHjGLpSyDNrWgiiiTPZ1OeqzUmG5RXGnCkSLGef2wpAVwLg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "R_Problem");

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9500), new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9527), new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9530), new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9533), new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9537), new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9537) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5717), new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5746), new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5755), new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5760), new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5767), new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5774), new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5244), new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "Name", "NormalizedName" },
                values: new object[] { "edca20fc-8a40-4922-b394-89090c2907f2", new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(6019), new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(5863), "管理员", "管理员" });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9606), new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9610), new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9612), new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9613), new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9615), new DateTime(2024, 3, 27, 21, 17, 22, 260, DateTimeKind.Local).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "PasswordHash" },
                values: new object[] { "12daf2cb-78d0-4047-9f60-ff3e52927696", new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(6154), new DateTime(2024, 3, 27, 21, 17, 22, 250, DateTimeKind.Local).AddTicks(6141), "AQAAAAEAACcQAAAAELvDyAVZFCjr2SQGCBh3p7CRPXHN/cuNNI8Iun6TwZ4H9ZYNvPLeVoJYBIBJxqliVw==" });
        }
    }
}
