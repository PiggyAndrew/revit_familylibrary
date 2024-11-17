using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class deletefamilynameproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "R_Family",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4264), new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(460), new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(469), new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(472), new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(474), new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(477), new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4468), new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4470), new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4472), new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4475), new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4477), new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4480), new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4445), new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime" },
                values: new object[] { "8e43c02f-a3f5-4b9d-8a7d-17d3be0698d5", new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4566), new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(529), new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(534), new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(536), new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(537), new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(538), new DateTime(2024, 6, 16, 15, 55, 48, 541, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "PasswordHash" },
                values: new object[] { "c0e60be5-d254-4318-b25c-e2d76c4c14b4", new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4607), new DateTime(2024, 6, 16, 15, 55, 48, 539, DateTimeKind.Local).AddTicks(4601), "AQAAAAEAACcQAAAAEERGdcIJ4KzXBbIKbZfnIPXjZMA94SEDEbIXma0VFvR3mgbqVxxYBi9odExhKSisgQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "R_Family",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(7954), new DateTime(2024, 6, 15, 22, 45, 25, 920, DateTimeKind.Local).AddTicks(7952) });

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
    }
}
