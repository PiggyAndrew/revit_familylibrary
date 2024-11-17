using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class addfamilykeycolmun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Key",
                table: "R_ProjectFolder",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L,
                comment: "相同文件标识");

            migrationBuilder.AddColumn<long>(
                name: "Key",
                table: "R_Family",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L,
                comment: "相同文件标识");

            migrationBuilder.UpdateData(
                table: "R_Family",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9540), new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9550), new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9551), new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9553), new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9555), new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(5922), new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(5923), new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(5925), new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(5926), new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(5927), new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(5928), new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(5911), new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime" },
                values: new object[] { "50e9b203-9493-44a9-95f9-5495733db36a", new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(5982), new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9578), new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9581), new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9582), new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9583), new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9584), new DateTime(2024, 6, 15, 22, 41, 26, 786, DateTimeKind.Local).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "PasswordHash" },
                values: new object[] { "db0d4b4c-714a-46cb-a8d9-a36306991bdd", new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(6009), new DateTime(2024, 6, 15, 22, 41, 26, 785, DateTimeKind.Local).AddTicks(6004), "AQAAAAEAACcQAAAAEDhrHg892qFv/XV/HKYHowEPO3kWQAxeC3EfheYSlqtL/S4HoWbm3K1AO8hCcuSQfw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Key",
                table: "R_ProjectFolder");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "R_Family");

            migrationBuilder.UpdateData(
                table: "R_Family",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8380), new DateTime(2024, 6, 15, 19, 39, 8, 486, DateTimeKind.Local).AddTicks(8378) });

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
    }
}
