using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class addcategorytagforFamily : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "R_Category",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false, comment: "类别名称"),
                    ParentId = table.Column<long>(type: "INTEGER", nullable: false, comment: "递归表存储树形关系"),
                    CategoryType = table.Column<int>(type: "INTEGER", nullable: false, comment: "分类类型"),
                    CreatorId = table.Column<long>(type: "INTEGER", nullable: false, comment: "创建者Id"),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "创建时间"),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "最后编辑时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "R_FamilyCategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryId = table.Column<long>(type: "INTEGER", nullable: false),
                    FamilyId = table.Column<long>(type: "INTEGER", nullable: false),
                    CreatorId = table.Column<long>(type: "INTEGER", nullable: false, comment: "创建者Id"),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "创建时间"),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "最后编辑时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_FamilyCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_R_FamilyCategory_R_Category_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "R_Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_R_FamilyCategory_R_Family_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "R_Family",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "R_Category",
                columns: new[] { "Id", "CategoryType", "CreationTime", "CreatorId", "LastModificationTime", "Name", "ParentId" },
                values: new object[] { 1L, 5, new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9056), 0L, new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9070), "全部", 0L });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2788), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2794), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2796), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2798), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2800), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9221), new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9245), new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9247), new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9248), new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9247) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9249), new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9250), new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9207), new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime" },
                values: new object[] { "5d64e515-28cd-42ac-9110-b32e607e18c7", new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9306), new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2828), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2833), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2834), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2835), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2836), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "PasswordHash" },
                values: new object[] { "e4bf5078-5c2b-43d9-8473-b2c819f4aa68", new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9334), new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9330), "AQAAAAEAACcQAAAAEMdQmgOtcqAjShZsJHxJDFIkQkEe7YSZUnRpNOUUnCOlBulfxZ3lMRNfAwChO29mww==" });

            migrationBuilder.CreateIndex(
                name: "IX_R_FamilyCategory_FamilyId",
                table: "R_FamilyCategory",
                column: "FamilyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "R_FamilyCategory");

            migrationBuilder.DropTable(
                name: "R_Category");

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
    }
}
