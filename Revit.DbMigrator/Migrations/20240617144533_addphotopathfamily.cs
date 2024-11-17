using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class addphotopathfamily : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MainPhotoPath",
                table: "R_Family",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                comment: "族主图");

            migrationBuilder.UpdateData(
                table: "R_Family",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime", "MainPhotoPath" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(6976), new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(6970), "" });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(3954), new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(3972), new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(3972) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(3975), new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(3977), new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(3981), new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(7306), new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(7307), new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(7309), new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(7310), new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(7312), new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(7313), new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(7268), new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime" },
                values: new object[] { "1fba6cdd-036c-4222-b410-09f5d05557a6", new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(7431), new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(4033), new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(4039), new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(4040), new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(4041), new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(4042), new DateTime(2024, 6, 17, 22, 45, 32, 443, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "PasswordHash" },
                values: new object[] { "8286aea3-4f37-4880-90b9-7e8f0cb4c86c", new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(7507), new DateTime(2024, 6, 17, 22, 45, 32, 441, DateTimeKind.Local).AddTicks(7493), "AQAAAAEAACcQAAAAEGcSJkPESF7+edqyY3BKs0P5x15iiU+2/dGQnDZ3M0L70cHiCxI4s5wHQTf6Pecxpg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainPhotoPath",
                table: "R_Family");

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
    }
}
