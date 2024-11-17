using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class addfamilytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "R_Family",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    FilePath = table.Column<string>(type: "TEXT", nullable: false, comment: "文件路径"),
                    CreatorId = table.Column<long>(type: "INTEGER", nullable: false, comment: "创建者Id"),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "创建时间"),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "最后编辑时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_Family", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "R_FamilyUser",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<long>(type: "INTEGER", nullable: false),
                    FamilyId = table.Column<long>(type: "INTEGER", nullable: false),
                    CreatorId = table.Column<long>(type: "INTEGER", nullable: false, comment: "创建者Id"),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "创建时间"),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "最后编辑时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_FamilyUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_R_FamilyUser_R_Family_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "R_Family",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "R_Family",
                columns: new[] { "Id", "CreationTime", "CreatorId", "FilePath", "LastModificationTime", "Name" },
                values: new object[] { 1L, new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2437), 1L, "NULL", new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2436), "TESTFAMILY" });

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

            migrationBuilder.CreateIndex(
                name: "IX_R_FamilyUser_FamilyId",
                table: "R_FamilyUser",
                column: "FamilyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "R_FamilyUser");

            migrationBuilder.DropTable(
                name: "R_Family");

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
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime" },
                values: new object[] { "7462ab23-9dc5-48e3-bdd2-c3d733b8e278", new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(9656), new DateTime(2024, 5, 4, 22, 33, 27, 444, DateTimeKind.Local).AddTicks(9418) });

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
    }
}
