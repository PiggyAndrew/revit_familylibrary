using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class modifyrfamily : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "R_Family");

            migrationBuilder.AddColumn<string>(
                name: "AbsolutePath",
                table: "R_ProjectFolder",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                comment: "绝对路径");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "R_Family",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                comment: "文件名称无后缀",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "AbsolutePath",
                table: "R_Family",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                comment: "绝对路径");

            migrationBuilder.AddColumn<string>(
                name: "FileExtension",
                table: "R_Family",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                comment: "后缀名称");

            migrationBuilder.AddColumn<string>(
                name: "FileSize",
                table: "R_Family",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                comment: "文件大小");

            migrationBuilder.AddColumn<string>(
                name: "RelativePath",
                table: "R_Family",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                comment: "相对路径");

            migrationBuilder.UpdateData(
                table: "R_Family",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AbsolutePath", "CreationTime", "FileExtension", "FileSize", "LastModificationTime", "RelativePath" },
                values: new object[] { "", new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8380), "", "", new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8378), "" });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2546), new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2556), new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2557), new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2559), new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2561), new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8540), new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8542), new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8543), new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8544), new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8546), new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8547), new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8509), new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime" },
                values: new object[] { "95b569e0-e72c-407d-bb60-787fde07fc84", new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8605), new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8563) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2592), new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2592) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2595), new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2597), new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2597), new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2598), new DateTime(2024, 6, 15, 19, 39, 8, 488, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "PasswordHash" },
                values: new object[] { "d2f1384d-a00a-43c5-a8ae-6c8d7ff6084a", new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8640), new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8635), "AQAAAAEAACcQAAAAEEhqpz+j9LyZ/4eatQbsuOYhLB2nYlXPpw2rC2xegq+PGFkg7FzQCJxYw0vfxwcwtg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AbsolutePath",
                table: "R_ProjectFolder");

            migrationBuilder.DropColumn(
                name: "AbsolutePath",
                table: "R_Family");

            migrationBuilder.DropColumn(
                name: "FileExtension",
                table: "R_Family");

            migrationBuilder.DropColumn(
                name: "FileSize",
                table: "R_Family");

            migrationBuilder.DropColumn(
                name: "RelativePath",
                table: "R_Family");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "R_Family",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100,
                oldComment: "文件名称无后缀");

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "R_Family",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                comment: "文件路径");

            migrationBuilder.UpdateData(
                table: "R_Family",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "FilePath", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2437), "NULL", new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4811), new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4836), new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4840), new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4843), new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4847), new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2564), new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2566), new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2567), new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2568), new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2568) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2570), new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2571), new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2549), new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime" },
                values: new object[] { "94f492ce-0bf5-4f00-8977-e7b588af8cc7", new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2632), new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4910), new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4915), new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4917), new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4918), new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4919), new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "PasswordHash" },
                values: new object[] { "f64694bf-63b2-43a7-a6b5-a870ecd2b395", new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2663), new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2659), "AQAAAAEAACcQAAAAEBPD81huwnddt9ouM3VM/BDGfomuRAccFWKmQqR/VRPEZCl58xmjfTbzI0B/ncGilg==" });
        }
    }
}
