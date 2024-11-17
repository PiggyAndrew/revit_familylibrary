using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class addfamilyversion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "R_ProjectFolder",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                comment: "版本号");

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "R_Family",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                comment: "版本号");

            migrationBuilder.UpdateData(
                table: "R_Family",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime", "Version" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(7954), new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(7952), 1 });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1913), new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1940), new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1943), new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1944), new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1947), new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(8058), new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(8060), new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(8061), new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(8062), new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(8063), new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(8065), new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(8047), new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime" },
                values: new object[] { "3896c785-dda9-415f-9887-99e324685c0e", new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(8193), new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1967), new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1972), new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1973), new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1974), new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1975), new DateTime(2024, 6, 15, 22, 45, 25, 922, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "PasswordHash" },
                values: new object[] { "24e39841-ab73-4d37-b148-37ca646fc7fd", new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(8222), new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(8217), "AQAAAAEAACcQAAAAEN+lseghCsixfscEBRVC8G17jeuVym2WeVKlEEEsuWnjMIxvAWVequhMoCrUOJYaYA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Version",
                table: "R_ProjectFolder");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "R_Family");

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
    }
}
