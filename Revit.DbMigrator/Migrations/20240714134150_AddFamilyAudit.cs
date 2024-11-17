using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class AddFamilyAudit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "R_Family",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.AddColumn<int>(
                name: "FamilyAuditStatus",
                table: "R_Family",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                comment: "族状态");

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7581), new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7601), new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7603), new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7605), new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7608), new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 21, 41, 50, 285, DateTimeKind.Local).AddTicks(1917), new DateTime(2024, 7, 14, 21, 41, 50, 285, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 21, 41, 50, 285, DateTimeKind.Local).AddTicks(1920), new DateTime(2024, 7, 14, 21, 41, 50, 285, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 21, 41, 50, 285, DateTimeKind.Local).AddTicks(1921), new DateTime(2024, 7, 14, 21, 41, 50, 285, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 21, 41, 50, 285, DateTimeKind.Local).AddTicks(1922), new DateTime(2024, 7, 14, 21, 41, 50, 285, DateTimeKind.Local).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 21, 41, 50, 285, DateTimeKind.Local).AddTicks(1924), new DateTime(2024, 7, 14, 21, 41, 50, 285, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 21, 41, 50, 285, DateTimeKind.Local).AddTicks(1925), new DateTime(2024, 7, 14, 21, 41, 50, 285, DateTimeKind.Local).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 21, 41, 50, 285, DateTimeKind.Local).AddTicks(1811), new DateTime(2024, 7, 14, 21, 41, 50, 285, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime" },
                values: new object[] { "9a498773-4e41-4f99-9ea0-949fc8a5a7ba", new DateTime(2024, 7, 14, 21, 41, 50, 285, DateTimeKind.Local).AddTicks(1984), new DateTime(2024, 7, 14, 21, 41, 50, 285, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7711), new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7715), new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7717), new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7717), new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7718), new DateTime(2024, 7, 14, 21, 41, 50, 286, DateTimeKind.Local).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "PasswordHash" },
                values: new object[] { "4ff56ec3-ea1d-4e4d-b4e6-8bf7c4697775", new DateTime(2024, 7, 14, 21, 41, 50, 285, DateTimeKind.Local).AddTicks(2016), new DateTime(2024, 7, 14, 21, 41, 50, 285, DateTimeKind.Local).AddTicks(2010), "AQAAAAEAACcQAAAAEI1QklDCmiza9wL5kgISwlgcBrgmnDnAN16cqfzCrnD+WJqGt5whyM3sEdpepwk3KQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FamilyAuditStatus",
                table: "R_Family");

            migrationBuilder.InsertData(
                table: "R_Family",
                columns: new[] { "Id", "BackUpUrl", "CreationTime", "CreatorId", "FileBytesSize", "FileExtension", "FileSHA256Hash", "LastModificationTime", "MainPhotoUrl", "Name", "SameFileKey", "SaveUrl", "Version" },
                values: new object[] { 1L, null, new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2437), 1L, 0L, "", "", new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2435), null, "TESTFAMILY", 0L, null, 1 });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9003), new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9038), new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9040), new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9050), new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9062), new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2544), new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2546), new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2547), new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2548), new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2550), new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2551), new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2533), new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime" },
                values: new object[] { "f94e21dc-ee85-43b2-badc-c0a5a9cbaa08", new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2607), new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9142), new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9150), new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9151), new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9152), new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9153), new DateTime(2024, 7, 14, 9, 51, 23, 53, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "PasswordHash" },
                values: new object[] { "6794db59-ff71-4e71-97ee-45939d90bbeb", new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2633), new DateTime(2024, 7, 14, 9, 51, 23, 52, DateTimeKind.Local).AddTicks(2629), "AQAAAAEAACcQAAAAEJhd4nCrPJwjkNRgNSpHDVPxJM5g+0QLGNWWvgMEjMI8zjN2Y6okGPO3Vz6e9c4JmA==" });
        }
    }
}
